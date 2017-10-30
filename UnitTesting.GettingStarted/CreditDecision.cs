
namespace UnitTesting.GettingStarted
{
    /*
    public class CreditDecision
    {
        public string MakeCreditDecision(int creditScore)
        {
            var service = new CreditDecisionService(); || NEW creates dependency
            return service.GetCreditDecision(creditScore);
        }
    }
     * 
     * Here NEW keyword creates the dependcy with CreditDecisionService Class!

    */

    /*
     * 
     * public class CreditDecision{

    CreditDecisionService creditDecisionService;
    public CreditDecision(CreditDecisionService creditDecisionService)
    {
        this.creditDecisionService = creditDecisionService;
    }

    public string MakeCreditDecision(int creditScore){
       return creditDecisionService.GetCreditDecision(creditScore);
    }
     * 
     * 
     * 
     * Here we moved our dependency to the constructor. good we said we need CreditDecisionService
     * when we create CreditDecision but STILL this requires the concrete.
     * We need to interface or abstract class for the abstraction.
}
     * */

    public interface ICreditDecisionService
    {
        string GetCreditDecision(int creditScore);
    }

    public class CreditDecisionService : ICreditDecisionService
    {
        public string GetCreditDecision(int creditScore)
        {

            if (creditScore < 550)
                return "Declined";
            else if (creditScore < 675)
                return "Maybe";
            else
                return "We look forward to doing business with you!";
        }
    }

    public class CreditDecision
    {
        ICreditDecisionService creditDecisionService;

        public CreditDecision(ICreditDecisionService creditDecisionService)
        {
            this.creditDecisionService = creditDecisionService;
        }

        public string MakeCreditDecision(int creditScore)
        {
            return creditDecisionService.GetCreditDecision(creditScore);
        }
    }
}
