﻿namespace DSInternals.PowerShell
{
    using System;
    using DSInternals.DataStore;
    using System.Security.Principal;
    using DSInternals.Common.Data;
    // Transport object
    public class DomainController : IDomainController
    {
        public DateTime? BackupExpiration
        {
            get;
            set;
        }

        public long? BackupUsn
        {
            get;
            set;
        }

        public string Domain
        {
            get;
            set;
        }

        public SecurityIdentifier DomainSid
        {
            get;
            set;
        }

        public System.Guid DsaGuid
        {
            get;
            set;
        }

        public int? Epoch
        {
            get;
            set;
        }

        public long HighestCommittedUsn
        {
            get;
            set;
        }

        public Guid InvocationId
        {
            get;
            set;
        }

        public bool IsGlobalCatalog
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string DNSHostName
        {
            get;
            set;
        }

        public int NTDSSettingsDNT
        {
            get;
            set;
        }

        public DomainControllerOptions Options
        {
            get;
            set;
        }

        public string OSVersion
        {
            get;
            set;
        }

        public uint? OSVersionMajor
        {
            get;
            set;
        }

        public uint? OSVersionMinor
        {
            get;
            set;
        }

        public string OSName
        {
            get;
            set;
        }

        public DistinguishedName DomainNamingContext
        {
            get;
            set;
        }

        public DistinguishedName ServerReference
        {
            get;
            set;
        }

        public DistinguishedName ConfigurationNamingContext
        {
            get;
            set;
        }

        public DistinguishedName SchemaNamingContext
        {
            get;
            set;
        }

        public string SiteName
        {
            get;
            set;
        }

        public DatabaseState State
        {
            get;
            set;
        }

        public long? UsnAtIfm
        {
            get;
            set;
        }

        public string[] WritablePartitions
        {
            get;
            set;
        }

        public bool IsADAM
        {
            get;
            set;
        }
    }
}