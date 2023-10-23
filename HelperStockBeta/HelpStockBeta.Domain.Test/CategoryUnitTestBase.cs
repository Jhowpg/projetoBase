using FluentAssertions;
using HelperStockBeta.Domain.Entities;

namespace HelpStockBeta.Domain.Test
{
    #region Caso de testes positivos
    public class CategoryUnitTestBase
    {
        [Fact(DisplayName = "Category name is not null")]
        public void CreateCategory_whithValidParameters_ResultValid()
        {
            Action action = () => new Category(1, "Categoria Teste");
            action.Should()
                .NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();
            
        }
        [Fact(DisplayName = "Category not present id parameter.")]
        public void CreateCategory_IdParameter_ResultValid()
        {
            Action action = () => new Category("Categoria Teste");
            action.Should()
                .NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();

        }
    #endregion

        #region Casos de testes negativo
        [Fact(DisplayName = "Id negative exception")]
        public void CreateCategory_Negative_NegativeParameterId_ResutException()
        {
            Action action = () => new Category(-1, "Categoria Teste");
            action.Should()
                .Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Identification is positive values!");

        }
        [Fact(DisplayName = "Name in Category null.")]
        public void CreateCategory_NameParameter_ResutException()
        {
            Action action = () => new Category(1, null);
            action.Should()
                .Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is required!");

        }
        [Fact(DisplayName = "Name short for Category null.")]
        public void CreateCategory_NameParameterShort_ResutException()
        {
            Action action = () => new Category(1, "Ca");
            action.Should()
                .Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Name is minimum 3 charecters");

        }
        #endregion
    }
}