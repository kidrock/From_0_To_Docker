// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebApiSwaggerAndMvc.WebApi.Sdk
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApiSwaggerAndMvc.
    /// </summary>
    public static partial class ApiSwaggerAndMvcExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> GetValues(this IApiSwaggerAndMvc operations)
            {
                return operations.GetValuesAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetValuesAsync(this IApiSwaggerAndMvc operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetValuesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void AddValue(this IApiSwaggerAndMvc operations, string value = default(string))
            {
                operations.AddValueAsync(value).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddValueAsync(this IApiSwaggerAndMvc operations, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddValueWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static string GetValue(this IApiSwaggerAndMvc operations, int id)
            {
                return operations.GetValueAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetValueAsync(this IApiSwaggerAndMvc operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetValueWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void UpdateValue(this IApiSwaggerAndMvc operations, int id, string value = default(string))
            {
                operations.UpdateValueAsync(id, value).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateValueAsync(this IApiSwaggerAndMvc operations, int id, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateValueWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void DeleteValue(this IApiSwaggerAndMvc operations, int id)
            {
                operations.DeleteValueAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteValueAsync(this IApiSwaggerAndMvc operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteValueWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}