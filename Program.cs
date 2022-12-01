// See https://aka.ms/new-console-template for more information
Console.WriteLine("Main Module");
MenuManager menu = new MenuManager();
DialogManager dialog = new DialogManager();
int choice = 0;
bool cont = true;
do
{
    Console.Clear();
    menu.Display();
    choice = menu.GetChoice();
    Console.WriteLine(choice);
    switch (choice)
    {
        case 1:
            dialog.AddDialog();
            break;
        case 2:
            dialog.SubDialog();
            break;
        case 3:
            dialog.MultDialog();
            break;
        case 4:
            dialog.DivDialog();
            break;
        default:
            break;
    }
    cont = menu.AllowContinue();

}while(cont || choice == 5);
