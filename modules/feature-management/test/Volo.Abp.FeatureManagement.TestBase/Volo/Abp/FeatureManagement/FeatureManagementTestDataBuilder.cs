﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Features;
using Volo.Abp.Guids;

namespace Volo.Abp.FeatureManagement
{
    public class FeatureManagementTestDataBuilder : ITransientDependency
    {
        private readonly IFeatureValueRepository _featureValueRepository;
        private readonly IGuidGenerator _guidGenerator;
        private readonly FeatureManagementTestData _testData;

        public FeatureManagementTestDataBuilder(
            IGuidGenerator guidGenerator,
            FeatureManagementTestData testData, 
            IFeatureValueRepository featureValueRepository)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
            _featureValueRepository = featureValueRepository;
        }

        public void Build()
        {
            #region "Regular" edition features

            //SocialLogins
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.SocialLogins,
                    true.ToString().ToLowerInvariant(),
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Regular.ToString()
                )
            );

            //UserCount
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.UserCount,
                    "10",
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Regular.ToString()
                )
            );

            //ProjectCount
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.ProjectCount,
                    "1",
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Regular.ToString()
                )
            );

            #endregion

            #region "Enterprise" edition features

            //SocialLogins
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.SocialLogins,
                    true.ToString().ToLowerInvariant(),
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Enterprise.ToString()
                )
            );

            //EmailSupport
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.EmailSupport,
                    true.ToString().ToLowerInvariant(),
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Enterprise.ToString()
                )
            );

            //UserCount
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.UserCount,
                    "20",
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Enterprise.ToString()
                )
            );

            //ProjectCount
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.ProjectCount,
                    "3",
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Enterprise.ToString()
                )
            );

            //BackupCount
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.BackupCount,
                    "5",
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Enterprise.ToString()
                )
            );

            #endregion

            #region "Ultimate" edition features

            //SocialLogins
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.SocialLogins,
                    true.ToString().ToLowerInvariant(),
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Ultimate.ToString()
                )
            );

            //EmailSupport
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.EmailSupport,
                    true.ToString().ToLowerInvariant(),
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Ultimate.ToString()
                )
            );

            //EmailSupport
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.DailyAnalysis,
                    true.ToString().ToLowerInvariant(),
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Ultimate.ToString()
                )
            );

            //UserCount
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.UserCount,
                    "100",
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Ultimate.ToString()
                )
            );

            //ProjectCount
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.ProjectCount,
                    "10",
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Ultimate.ToString()
                )
            );

            //BackupCount
            _featureValueRepository.Insert(
                new FeatureValue(
                    _guidGenerator.Create(),
                    TestFeatureDefinitionProvider.BackupCount,
                    "10",
                    EditionFeatureValueProvider.ProviderName,
                    TestEditionIds.Ultimate.ToString()
                )
            );

            #endregion
        }
    }
}