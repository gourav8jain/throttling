﻿using Newtonsoft.Json;
using System.Text;

namespace throttling.Extensions
{
    public static class Serialization
    {
        public static byte[] ToByteArray(this object objectToSerialize)
        {
            if (objectToSerialize == null)
            {
                return null;
            }

            return Encoding.Default.GetBytes(JsonConvert.SerializeObject(objectToSerialize));
        }

        public static T FromByteArray<T>(this byte[] arrayToDeserialize) where T : class
        {
            if (arrayToDeserialize == null)
            {
                return default;
            }

            return JsonConvert.DeserializeObject<T>(Encoding.Default.GetString(arrayToDeserialize));
        }
    }
}
