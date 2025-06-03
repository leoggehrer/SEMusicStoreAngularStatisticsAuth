//@CodeCopy

#if IDINT_ON
global using IdType = System.Int32;
#elif IDLONG_ON
global using IdType = System.Int64;
#elif IDGUID_ON
global using IdType = System.Guid;
#else
global using IdType = System.Int32;
#endif

global using Common = SEMusicStoreAngularStatisticsAuth.Common;
global using CommonContracts = SEMusicStoreAngularStatisticsAuth.Common.Contracts;
global using CommonModels = SEMusicStoreAngularStatisticsAuth.Common.Models;
global using CommonModules = SEMusicStoreAngularStatisticsAuth.Common.Modules;
global using SEMusicStoreAngularStatisticsAuth.Common.Extensions;

