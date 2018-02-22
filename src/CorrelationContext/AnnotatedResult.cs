namespace CorrelationContext
{
    public class AnnotatedResult<T>
    {
        public T Result { get; set; }

        public long TimeElapsed { get; set; }

        public static implicit operator T(AnnotatedResult<T> thing)
        {
            return thing.Result;
        }
    }
}