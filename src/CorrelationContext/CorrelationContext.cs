using System;
using System.Diagnostics;

namespace CorrelationContext
{
    public class CorrelationContext
    {
        #region Actions

        public AnnotatedResult<NonReturningActionResult> Run(Action action)
        {
            //TODO: Any better way to do this?
            return Time(() => { action(); return new NonReturningActionResult(); });
        }

        public AnnotatedResult<NonReturningActionResult> Run<T>(Action<T> action, T arg1)
        {
            return Time(() => { action(arg1); return new NonReturningActionResult(); });
        }

        public AnnotatedResult<NonReturningActionResult> Run<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            return Time(() => { action(arg1, arg2); return new NonReturningActionResult(); });
        }

        public AnnotatedResult<NonReturningActionResult> Run<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return Time(() => { action(arg1, arg2, arg3); return new NonReturningActionResult(); });
        }

        public AnnotatedResult<NonReturningActionResult> Run<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return Time(() => { action(arg1, arg2, arg3, arg4); return new NonReturningActionResult(); });
        }

        public AnnotatedResult<NonReturningActionResult> Run<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return Time(() => { action(arg1, arg2, arg3, arg4, arg5); return new NonReturningActionResult(); });
        }

        #endregion


        #region Funcs

        private AnnotatedResult<TOut> Time<TOut>(Func<TOut> func)
        {
            var sw = Stopwatch.StartNew();
            var result = func();
            sw.Stop();

            return new AnnotatedResult<TOut>
            {
                Result = result,
                TimeElapsed = sw.ElapsedMilliseconds
            };
        }

        public AnnotatedResult<TOut> Run<TOut>(Func<TOut> func)
        {
            return Time(func);
        }

        public AnnotatedResult<TOut> Run<TOut, T1>(Func<T1, TOut> func, T1 arg1)
        {
            return Time(() => func(arg1));
        }

        public AnnotatedResult<TOut> Run<TOut, T1, T2>(Func<T1, T2, TOut> func, T1 arg1, T2 arg2)
        {
            return Time(() => func(arg1, arg2));
        }

        public AnnotatedResult<TOut> Run<TOut, T1, T2, T3>(Func<T1, T2, T3, TOut> func, T1 arg1, T2 arg2, T3 arg3)
        {
            return Time(() => func(arg1, arg2, arg3));
        }

        public AnnotatedResult<TOut> Run<TOut, T1, T2, T3, T4>(Func<T1, T2, T3, T4, TOut> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return Time(() => func(arg1, arg2, arg3, arg4));
        }

        public AnnotatedResult<TOut> Run<TOut, T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, TOut> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return Time(() => func(arg1, arg2, arg3, arg4, arg5));
        }
        #endregion
    }
}
