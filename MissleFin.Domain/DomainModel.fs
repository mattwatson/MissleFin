namespace MissleFin

[<AutoOpen>]
module DomainModel = 

  type AccountType = Asset | Liability | Income | Expense | Payable | Receivable | Equity

  [<CLIMutable>]
  type AccountTag = 
      { Id : int 
        Name : string }

  [<CLIMutable>]
  type Account =
      { Id : int
        Name : string
        Enabled : bool
        Type : AccountType
        Tags : int list }