
EXTRA_DIST =  

# Warning: This is an automatically generated file, do not edit!

if ENABLE_DEBUG
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- "-nowarn:1699,414,219" -debug "-define:TRACE;DEBUG;NUNIT_FRAMEWORK;NET_4_0" "-keyfile:nunit.snk"
ASSEMBLY = ../../bin/Debug/net-4.0/nunit.framework.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = ../../bin/Debug/net-4.0/

NUNIT_FRAMEWORK_DLL_MDB_SOURCE=../../bin/Debug/net-4.0/nunit.framework.dll.mdb
NUNIT_FRAMEWORK_DLL_MDB=$(BUILD_DIR)/nunit.framework.dll.mdb

endif

if ENABLE_RELEASE
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+ "-nowarn:414,219" "-define:TRACE;NUNIT_FRAMEWORK;NET_4_0" "-keyfile:nunit.snk"
ASSEMBLY = ../../bin/Release/net-4.0/nunit.framework.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = ../../bin/Release/net-4.0/

NUNIT_FRAMEWORK_DLL_MDB=

endif

AL=al
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(NUNIT_FRAMEWORK_DLL_MDB)  

LINUX_PKGCONFIG = \
	$(NUNIT_FRAMEWORK_SCHUMIX_PC)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

FILES = \
	../../CommonAssemblyInfo.cs \
	../../Common/nunit/AssemblyHelper.cs \
	../../Common/nunit/Env.cs \
	../../Common/nunit/Guard.cs \
	../../Common/nunit/Logging/ILogger.cs \
	../../Common/nunit/Logging/InternalTrace.cs \
	../../Common/nunit/Logging/InternalTraceLevel.cs \
	../../Common/nunit/Logging/InternalTraceWriter.cs \
	../../Common/nunit/Logging/Logger.cs \
	../../Common/nunit/PackageSettings.cs \
	../FrameworkVersion.cs \
	ActionTargets.cs \
	Api/DefaultTestAssemblyBuilder.cs \
	Api/FrameworkController.cs \
	Api/ITestAssemblyBuilder.cs \
	Api/ITestAssemblyRunner.cs \
	Api/NUnitTestAssemblyRunner.cs \
	Assert.Comparisons.cs \
	Assert.Conditions.cs \
	Assert.cs \
	Assert.Equality.cs \
	Assert.Exceptions.cs \
	Assert.That.cs \
	Assert.Types.cs \
	AssertionHelper.cs \
	Assume.cs \
	Attributes/ApartmentAttribute.cs \
	Attributes/AuthorAttribute.cs \
	Attributes/CategoryAttribute.cs \
	Attributes/CombinatorialAttribute.cs \
	Attributes/CombiningStrategyAttribute.cs \
	Attributes/LevelOfParallelismAttribute.cs \
	Attributes/OneTimeSetUpAttribute.cs \
	Attributes/OneTimeTearDownAttribute.cs \
	Attributes/RetryAttribute.cs \
	Attributes/TestActionAttribute.cs \
	Attributes/ParallelizableAttribute.cs \
	Attributes/CultureAttribute.cs \
	Attributes/DataAttribute.cs \
	Attributes/DatapointAttribute.cs \
	Attributes/DatapointsAttribute.cs \
	Attributes/DatapointSourceAttribute.cs \
	Attributes/DescriptionAttribute.cs \
	Attributes/ExplicitAttribute.cs \
	Attributes/IgnoreAttribute.cs \
	Attributes/IncludeExcludeAttribute.cs \
	Attributes/MaxTimeAttribute.cs \
	Attributes/NUnitAttribute.cs \
	Attributes/PairwiseAttribute.cs \
	Attributes/ParallelScope.cs \
	Attributes/PlatformAttribute.cs \
	Attributes/PropertyAttribute.cs \
	Attributes/RandomAttribute.cs \
	Attributes/RangeAttribute.cs \
	Attributes/RepeatAttribute.cs \
	Attributes/RequiresMTAAtribute.cs \
	Attributes/RequiresSTAAttribute.cs \
	Attributes/RequiresThreadAttribute.cs \
	Attributes/SequentialAttribute.cs \
	Attributes/SetCultureAttribute.cs \
	Attributes/SetUICultureAttribute.cs \
	Attributes/SetUpAttribute.cs \
	Attributes/SetUpFixtureAttribute.cs \
	Attributes/TearDownAttribute.cs \
	Attributes/TestAttribute.cs \
	Attributes/TestCaseAttribute.cs \
	Attributes/TestCaseSourceAttribute.cs \
	Attributes/TestFixtureAttribute.cs \
	Attributes/TestFixtureSetUpAttribute.cs \
	Attributes/TestFixtureSourceAttribute.cs \
	Attributes/TestFixtureTearDownAttribute.cs \
	Attributes/TestOfAttribute.cs \
	Attributes/TheoryAttribute.cs \
	Attributes/TimeoutAttribute.cs \
	Attributes/ValuesAttribute.cs \
	Attributes/ValueSourceAttribute.cs \
	CollectionAssert.cs \
	Compatibility/Activator.cs \
	Compatibility/AttributeHelper.cs \
	Compatibility/ICallbackEventHandler.cs \
	Compatibility/MarshalByRefObject.cs \
	Compatibility/Path.cs \
	Compatibility/SerializableAttribute.cs \
	Compatibility/Stopwatch.cs \
	Constraints/AllItemsConstraint.cs \
	Constraints/AndConstraint.cs \
	Constraints/AssignableFromConstraint.cs \
	Constraints/AssignableToConstraint.cs \
	Constraints/AttributeConstraint.cs \
	Constraints/AttributeExistsConstraint.cs \
	Constraints/BinaryConstraint.cs \
	Constraints/BinarySerializableConstraint.cs \
	Constraints/CollectionConstraint.cs \
	Constraints/CollectionContainsConstraint.cs \
	Constraints/CollectionEquivalentConstraint.cs \
	Constraints/CollectionItemsEqualConstraint.cs \
	Constraints/CollectionOrderedConstraint.cs \
	Constraints/CollectionSupersetConstraint.cs \
	Constraints/CollectionSubsetConstraint.cs \
	Constraints/CollectionTally.cs \
	Constraints/ComparisonAdapter.cs \
	Constraints/ComparisonConstraint.cs \
	Constraints/Constraint.cs \
	Constraints/ConstraintBuilder.cs \
	Constraints/ConstraintExpression.cs \
	Constraints/ConstraintFactory.cs \
	Constraints/ConstraintResult.cs \
	Constraints/ContainsConstraint.cs \
	Constraints/DelayedConstraint.cs \
	Constraints/DictionaryContainsKeyConstraint.cs \
	Constraints/DictionaryContainsValueConstraint.cs \
	Constraints/EmptyCollectionConstraint.cs \
	Constraints/EmptyConstraint.cs \
	Constraints/EmptyDirectoryConstraint.cs \
	Constraints/EmptyStringConstraint.cs \
	Constraints/EndsWithConstraint.cs \
	Constraints/EqualConstraint.cs \
	Constraints/EqualityAdapter.cs \
	Constraints/ExactTypeConstraint.cs \
	Constraints/FalseConstraint.cs \
	Constraints/FileExistsConstraint.cs \
	Constraints/FileOrDirectoryExistsConstraint.cs \
	Constraints/FloatingPointNumerics.cs \
	Constraints/GreaterThanConstraint.cs \
	Constraints/GreaterThanOrEqualConstraint.cs \
	Constraints/IConstraint.cs \
	Constraints/InstanceOfTypeConstraint.cs \
	Constraints/IResolveConstraint.cs \
	Constraints/LessThanConstraint.cs \
	Constraints/LessThanOrEqualConstraint.cs \
	Constraints/MessageWriter.cs \
	Constraints/MsgUtils.cs \
	Constraints/NaNConstraint.cs \
	Constraints/NoItemConstraint.cs \
	Constraints/NotConstraint.cs \
	Constraints/NullConstraint.cs \
	Constraints/Numerics.cs \
	Constraints/NUnitComparer.cs \
	Constraints/NUnitEqualityComparer.cs \
	Constraints/Operators/AllOperator.cs \
	Constraints/Operators/AndOperator.cs \
	Constraints/Operators/AttributeOperator.cs \
	Constraints/Operators/BinaryOperator.cs \
	Constraints/Operators/CollectionOperator.cs \
	Constraints/Operators/ConstraintOperator.cs \
	Constraints/Operators/NoneOperator.cs \
	Constraints/Operators/NotOperator.cs \
	Constraints/Operators/OrOperator.cs \
	Constraints/Operators/PrefixOperator.cs \
	Constraints/Operators/PropOperator.cs \
	Constraints/Operators/SelfResolvingOperator.cs \
	Constraints/Operators/SomeOperator.cs \
	Constraints/Operators/ThrowsOperator.cs \
	Constraints/Operators/WithOperator.cs \
	Constraints/OrConstraint.cs \
	Constraints/PathConstraint.cs \
	Constraints/PredicateConstraint.cs \
	Constraints/PrefixConstraint.cs \
	Constraints/PropertyConstraint.cs \
	Constraints/PropertyExistsConstraint.cs \
	Constraints/RangeConstraint.cs \
	Constraints/RegexConstraint.cs \
	Constraints/ResolvableConstraintExpression.cs \
	Constraints/ReusableConstraint.cs \
	Constraints/SameAsConstraint.cs \
	Constraints/SamePathConstraint.cs \
	Constraints/SamePathOrUnderConstraint.cs \
	Constraints/SomeItemsConstraint.cs \
	Constraints/EqualConstraintResult.cs \
	Constraints/StartsWithConstraint.cs \
	Constraints/StringConstraint.cs \
	Constraints/SubPathConstraint.cs \
	Constraints/SubstringConstraint.cs \
	Constraints/ThrowsConstraint.cs \
	Constraints/ThrowsExceptionConstraint.cs \
	Constraints/ThrowsNothingConstraint.cs \
	Constraints/Tolerance.cs \
	Constraints/ToleranceMode.cs \
	Constraints/TrueConstraint.cs \
	Constraints/TypeConstraint.cs \
	Constraints/UniqueItemsConstraint.cs \
	Constraints/XmlSerializableConstraint.cs \
	Contains.cs \
	DirectoryAssert.cs \
	Does.cs \
	Exceptions/AssertionException.cs \
	Exceptions/IgnoreException.cs \
	Exceptions/InconclusiveException.cs \
	Exceptions/ResultStateException.cs \
	Exceptions/SuccessException.cs \
	Interfaces/IApplyToContext.cs \
	Interfaces/IApplyToTest.cs \
	Interfaces/ICombiningStrategy.cs \
	Interfaces/ICommandWrapper.cs \
	Interfaces/IFixtureBuilder.cs \
	Interfaces/IImplyFixture.cs \
	Interfaces/IParameterDataProvider.cs \
	FileAssert.cs \
	GlobalSettings.cs \
	Has.cs \
	Interfaces/IParameterDataSource.cs \
	Interfaces/IPropertyBag.cs \
	Interfaces/ISimpleTestBuilder.cs \
	Interfaces/ISuiteBuilder.cs \
	Interfaces/ITest.cs \
	Interfaces/ITestBuilder.cs \
	Interfaces/ITestCaseBuilder.cs \
	Interfaces/ITestCaseData.cs \
	Interfaces/ITestData.cs \
	Interfaces/ITestFilter.cs \
	Interfaces/ITestFixtureData.cs \
	Interfaces/ITestListener.cs \
	Interfaces/ITestResult.cs \
	Interfaces/IXmlNodeBuilder.cs \
	Interfaces/ResultState.cs \
	Interfaces/RunState.cs \
	Interfaces/TestStatus.cs \
	Interfaces/TNode.cs \
	Internal/ActionsHelper.cs \
	Internal/AsyncInvocationRegion.cs \
	Internal/Builders/CombinatorialStrategy.cs \
	Internal/Builders/DatapointProvider.cs \
	Internal/Builders/DefaultTestCaseBuilder.cs \
	Internal/Builders/NamespaceTreeBuilder.cs \
	Internal/Builders/NUnitTestCaseBuilder.cs \
	Internal/Builders/NUnitTestFixtureBuilder.cs \
	Internal/Builders/DefaultSuiteBuilder.cs \
	Internal/Builders/PairwiseStrategy.cs \
	Internal/Builders/ParameterDataProvider.cs \
	Internal/Builders/ProviderCache.cs \
	Internal/Builders/SequentialStrategy.cs \
	Internal/Commands/ApplyChangesToContextCommand.cs \
	Internal/Commands/CommandStage.cs \
	Internal/Commands/DelegatingTestCommand.cs \
	Internal/Commands/MaxTimeCommand.cs \
	Internal/Commands/OneTimeSetUpCommand.cs \
	Internal/Commands/OneTimeTearDownCommand.cs \
	Internal/Commands/SetUpTearDownCommand.cs \
	Internal/Commands/SetUpTearDownItem.cs \
	Internal/Commands/SkipCommand.cs \
	Internal/Commands/TestActionCommand.cs \
	Internal/Commands/TestActionItem.cs \
	Internal/Commands/TestCommand.cs \
	Internal/Commands/TestMethodCommand.cs \
	Internal/Commands/TheoryResultCommand.cs \
	Internal/CultureDetector.cs \
	Internal/ExceptionHelper.cs \
	Internal/Execution/CommandBuilder.cs \
	Internal/Execution/CompositeWorkItem.cs \
	Internal/Execution/CountdownEvent.cs \
	Internal/Execution/EventPump.cs \
	Internal/Execution/EventQueue.cs \
	Internal/Execution/IWorkItemDispatcher.cs \
	Internal/Execution/ParallelWorkItemDispatcher.cs \
	Internal/Execution/QueuingEventListener.cs \
	Internal/Execution/SimpleWorkItem.cs \
	Internal/Execution/SimpleWorkItemDispatcher.cs \
	Internal/Execution/TestWorker.cs \
	Internal/Execution/TextCapture.cs \
	Internal/Execution/TextMessageWriter.cs \
	Internal/Execution/WorkItem.cs \
	Internal/Execution/WorkItemQueue.cs \
	Internal/Execution/WorkItemState.cs \
	Internal/Execution/WorkShift.cs \
	Internal/Filters/AndFilter.cs \
	Internal/Filters/CategoryFilter.cs \
	Internal/Filters/IdFilter.cs \
	Internal/Filters/NotFilter.cs \
	Internal/Filters/OrFilter.cs \
	Internal/Filters/SimpleNameFilter.cs \
	Internal/Filters/ValueMatchFilter.cs \
	Internal/GenericMethodHelper.cs \
	Internal/InvalidDataSourceException.cs \
	Internal/InvalidTestFixtureException.cs \
	Internal/MethodHelper.cs \
	Internal/NetCFExtensions.cs \
	Internal/NUnitException.cs \
	Internal/OSPlatform.cs \
	Internal/PlatformHelper.cs \
	Internal/PropertyBag.cs \
	Internal/PropertyNames.cs \
	Internal/Randomizer.cs \
	Internal/Reflect.cs \
	Internal/Results/TestResult.cs \
	Internal/RuntimeFramework.cs \
	Internal/StackFilter.cs \
	Internal/StringUtil.cs \
	Internal/TestCaseParameters.cs \
	Internal/TestExecutionContext.cs \
	Internal/TestExecutionStatus.cs \
	Internal/TestFilter.cs \
	Internal/TestFixtureParameters.cs \
	Internal/TestListener.cs \
	Internal/TestParameters.cs \
	Internal/TestProgressReporter.cs \
	Internal/Tests/ParameterizedFixtureSuite.cs \
	Internal/Tests/ParameterizedMethodSuite.cs \
	Internal/Tests/SetUpFixture.cs \
	Internal/Tests/Test.cs \
	Internal/Tests/TestAssembly.cs \
	Internal/Tests/TestFixture.cs \
	Internal/Tests/TestMethod.cs \
	Internal/Tests/TestSuite.cs \
	Internal/ThreadUtility.cs \
	Internal/TypeHelper.cs \
	Is.cs \
	ITestAction.cs \
	Iz.cs \
	List.cs \
	ListMapper.cs \
	Properties/AssemblyInfo.cs \
	SpecialValue.cs \
	StringAssert.cs \
	TestCaseData.cs \
	TestContext.cs \
	TestFixtureData.cs \
	Throws.cs \
	Internal/Results/TestCaseResult.cs \
	Internal/Results/TestSuiteResult.cs \
	Constraints/ExactCountConstraint.cs \
	Constraints/Operators/ExactCountOperator.cs \
	Constraints/ExceptionTypeConstraint.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	nunit.snk \
	Attributes/AttributeHierarchy.txt \
	nunit.framework.schumix.pc.in 

REFERENCES =  \
	System \
	System.Data \
	System.Configuration \
	System.Web \
	System.Xml \
	System.Core

DLL_REFERENCES = 

CLEANFILES = $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

include $(top_srcdir)/Makefile.include

NUNIT_FRAMEWORK_SCHUMIX_PC = $(BUILD_DIR)/nunit.framework.schumix.pc

$(eval $(call emit-deploy-wrapper,NUNIT_FRAMEWORK_SCHUMIX_PC,nunit.framework.schumix.pc))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY_MDB): $(ASSEMBLY)

$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
