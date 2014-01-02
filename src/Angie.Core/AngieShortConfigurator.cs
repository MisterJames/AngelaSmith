using System.Collections.Generic;
using System.Reflection;

namespace Angela.Core
{
    public class AngieShortConfigurator<T> : AngieConfigurator<T> where T : new()
    {
        private MemberInfo _propertyInfo;

        public AngieShortConfigurator(Angie angie, Maggie maggie, MemberInfo propertyInfo)
            : base(angie, maggie)
        {
            _propertyInfo = propertyInfo;
        }

        /// <summary>
        /// Fill the target property with values between the specified range
        /// </summary>
        /// <param name="min">The minimum value (inclusive)</param>
        /// <param name="max">The maximum value (inclusive)</param>
        /// <returns>A configurator for the target object type</returns>
        public AngieConfigurator<T> WithinRange(short min, short max)
        {
            ShortFiller filler = new ShortFiller(typeof(T), _propertyInfo.Name, min, max);
            _maggie.RegisterFiller(filler);
            return this;
        }
        
        /// <summary>
        /// Fill the target property with a random value from the specified array
        /// </summary>
        /// <param name="values">A array of values to choose from</param>
        /// <returns>A configurator for the target object type</returns>
        public AngieConfigurator<T> WithRandom(short[] values)
        {
            CustomFiller<short> customFiller = new CustomFiller<short>(PropertyInfo.Name, typeof(T), () => BaseValueGenerator.GetRandomValue(values));
            _maggie.RegisterFiller(customFiller);
            return this;
        }

        /// <summary>
        /// Fill the target property with a random value from the specified list
        /// </summary>
        /// <param name="values">A list of values to choose from</param>
        /// <returns>A configurator for the target object type</returns>
        public AngieConfigurator<T> WithRandom(List<short> values)
        {
            CustomFiller<short> customFiller = new CustomFiller<short>(PropertyInfo.Name, typeof(T), () => BaseValueGenerator.GetRandomValue(values));
            _maggie.RegisterFiller(customFiller);
            return this;
        }

        /// <summary>
        /// Fill the target property with a random value from the specified enumerable
        /// </summary>
        /// <param name="values">A enumerable of values to choose from</param>
        /// <returns>A configurator for the target object type</returns>
        public AngieConfigurator<T> WithRandom(IEnumerable<short> values)
        {
            CustomFiller<short> customFiller = new CustomFiller<short>(PropertyInfo.Name, typeof(T), () => BaseValueGenerator.GetRandomValue(values));
            _maggie.RegisterFiller(customFiller);
            return this;
        }

        public MemberInfo PropertyInfo
        {
            get { return _propertyInfo; }
        }
    }
}