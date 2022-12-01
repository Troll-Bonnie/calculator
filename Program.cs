// See https://aka.ms/new-console-template for more information
Console.WriteLine("Main Module");
MenuManager menu = new MenuManager();
DialogManager dialog = new DialogManager();
int choice = 0;
do
{
    Console.Clear();
    menu.Display();
    menu.GetChoice();
    switch (choice)
    {
        case 1:
            dialog.AddDialog();
            break;
        case 1:
            dialog.SubDialog();
            break;
        case 1:
            dialog.MultDialog();
            break;
        case 1:
            dialog.DivDialog();
            break;
        default:
            break;
    }

}while(menu.AllowContinue() || choice == 5);
