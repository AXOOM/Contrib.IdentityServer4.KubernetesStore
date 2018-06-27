﻿namespace Contrib.IdentityServer4.KubernetesStore
{
    public class KubernetesConfigurationStoreOptions
    {
        /// <summary>
        /// The connection string which points to the Kubernetes cluster.
        /// If not set, the service assumes that it runs inside the kubernetes cluster and autoconfigures itself.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// The Kubernetes namespace containing the custom resources.
        /// If not set, all namespaces are searched.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Indicating whether to auto create the Custom Resource Definitions for
        /// <c>IdentityClient</c>, <c>IdentityUserResource</c> and <c>IdentityApiResource</c> into the cluster or not.
        /// </summary>
        /// <remarks>Defaults to <c>false</c>.</remarks>
        public bool AutoCreateCrds { get; set; }
    }
}