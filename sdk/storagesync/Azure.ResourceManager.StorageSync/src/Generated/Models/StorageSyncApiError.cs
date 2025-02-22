// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Error type. </summary>
    public partial class StorageSyncApiError
    {
        /// <summary> Initializes a new instance of StorageSyncApiError. </summary>
        internal StorageSyncApiError()
        {
        }

        /// <summary> Initializes a new instance of StorageSyncApiError. </summary>
        /// <param name="code"> Error code of the given entry. </param>
        /// <param name="message"> Error message of the given entry. </param>
        /// <param name="target"> Target of the given error entry. </param>
        /// <param name="details"> Error details of the given entry. </param>
        /// <param name="innererror"> Inner error details of the given entry. </param>
        internal StorageSyncApiError(string code, string message, string target, StorageSyncErrorDetails details, StorageSyncInnerErrorDetails innererror)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
        }

        /// <summary> Error code of the given entry. </summary>
        public string Code { get; }
        /// <summary> Error message of the given entry. </summary>
        public string Message { get; }
        /// <summary> Target of the given error entry. </summary>
        public string Target { get; }
        /// <summary> Error details of the given entry. </summary>
        public StorageSyncErrorDetails Details { get; }
        /// <summary> Inner error details of the given entry. </summary>
        public StorageSyncInnerErrorDetails Innererror { get; }
    }
}
