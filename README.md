# SmallWinformExample
Hello fellows, this a small project on WinForm, the context of the project is a small book store where a customer can buy books. Easy :).

The customer will have a membership to get discount for the purchase made.

The stack:
WinForm
Entity framework 6.1.3
SQL server
Code first(I activated the migration)

The solution have four projects:
- App: Where all the views are.
- DAL: Where you can find the model entities and the repository.
- Services: Here is where you can ask for services client, book, etc.
- BusinessLayer: Here are the rules of the business.

In the solution you will find a factory pattern, repository pattern and some DI(Dependence injection).

I am still working on the solution, I have not define the scope. If you see something comes up like no validation on the view, we will get at that point to fix it.

To see, use or collaborate in the project, clone and make sure there is no migration file in the migrations directory.
