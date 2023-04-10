namespace Application.UseCases.EmployeeUseCases.GetEmployeeById
{
    public interface IGetEmployeeByIdInputPort
    {
        Task Handle(int Id);
    }
}
