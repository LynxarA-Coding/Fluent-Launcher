using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Launcher
{
    public class Localization
    {
        public Dictionary<string, Dictionary<string, string>> Localized = new Dictionary<string, Dictionary<string, string>>()
        {
            {"FolderNotValid", new Dictionary<string, string>()
            {
                {"en-EN", "The Steam folder is not valid!"},
                {"ru-RU", "Папка Steam выбрана не верно"},
                {"fr-FR", "Le dossier Steam n'est pas valide"}
            }},
            {"Errortitle", new Dictionary<string, string>()
            {
                {"en-EN", "Error"},
                {"ru-RU", "Ошибка"},
                {"fr-FR", "Erreur"}
            }},
            {"NotEnoughFiles", new Dictionary<string, string>()
            {
                {"en-EN", "There are no files for the Fluent installation. Please, download the program again."},
                {"ru-RU", "Недостаточно файлов для установки Fluent. Пожалуйста, скачайте программу снова."},
                {"fr-FR", "Il n'y a pas de fichiers pour l'installation. Veuillez retélécharger le programme."}
            }},
            {"SuccessTitle", new Dictionary<string, string>()
            {
                {"en-EN", "Success"},
                {"ru-RU", "Успех"},
                {"fr-FR", "Succès"}
            }},
            {"SuccessInstalled", new Dictionary<string, string>()
            {
                {"en-EN", "Fluent for Steam was installed successfully!"},
                {"ru-RU", "Fluent для Steam был успешно установлен!"},
                {"fr-FR", "Fluent pour Steam a été installé avec succès!"}
            }},
            {"SuccessDeleted", new Dictionary<string, string>()
            {
                {"en-EN", "Fluent For Steam has been uninstalled successfully!"},
                {"ru-RU", "Fluent для Steam был успешно удален!"},
                {"fr-FR", "Fluent pour Steam a été désinstallé avec succès!"}
            }},
            {"SuccessDeletedSFP", new Dictionary<string, string>()
            {
                {"en-EN", "Fluent For Steam has been uninstalled successfully! Since you have SFP, Dark Friends and Dark Library were uninstalled too (check the uninstall disclaimer)"},
                {"ru-RU", "Fluent для Steam был успешно удален! Так как у вас установлен SFP, Dark Friends List и Dark Library были удалены (проверьте дисклеймер при удалении)"},
                {"fr-FR", "Fluent pour Steam a été désinstallé avec succès! Puisque vous avez SFP, Dark Friends et Dark Library ont été désinstallés aussi (vérifiez le disclaimer de désinstallation)"}
            }},
            {"UninstallPrompt", new Dictionary<string, string>()
            {
                {"en-EN", "Uninstall Fluent for Steam will remove the skin from your Steam folder, and will not delete any of your Steam files. However, your SFP patch (if done) will be corrupt if you checked the \"I've already Patched SFP\". If you want to use it - patch again after uninstalling the skin."},
                {"fr-FR", "Désinstaller Fluent for Steam supprimera le skin de votre dossier Steam, et ne supprimera aucun de vos fichiers Steam. Cependant, le patch SFP (si fait) sera corrompu si vous avez coché \"J'ai déjà patcher avec SFP\". Si vous souhaitez l'utiliser - veuillez patcher Steam après avoir désinstaller le skin"},
                {"ru-RU", "Удаление Fluent for Steam удалит скин из вашей папки Steam, и не удалит никаких файлов Steam. Однако, ваш SFP патч (если вы его делали) будет испорчен, если вы отметили \"Я уже патчил SFP\". Если вы хотите его использовать - патчите Steam снова после удаления скина."}
            }},
            {"ShadowPrompt", new Dictionary<string, string>()
            {
                {"en-EN", "This patch requires special arguments in the .exe of the Steam. If you click YES, you need to select your Steam Shortcut! (NOT STEAM.EXE, SHORTCUT). This action will update shortcut arguments."},
                {"fr-FR", "Ce patch nécessite des arguments spéciaux dans le .exe de Steam. Si vous cliquez sur OUI, vous devez sélectionner votre raccourci Steam! (PAS STEAM.EXE, RACCOURCI). Cette action mettra à jour les arguments du raccourci."},
                {"ru-RU", "Этот патч требует специальные аргументы в .exe Steam. Если вы нажмете ДА, вам нужно будет выбрать ярлык Steam! (НЕ STEAM.EXE, ЯРЛЫК). Это действие обновит аргументы ярлыка."}
            }}
        };
    }
}
