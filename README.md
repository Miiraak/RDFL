# RDFL
`RDFL - RemoveDuplicateFromList` est une application Windows Forms développée en C# qui permet de supprimer les doublons dans un fichier texte. 

Je trouvais pas de moyen rapide de nettoyer une concaténation de dictionnaire de mot de passe, et chat GPT le fais à 20% avant de s'arrêter et de se dire mais c'est contre l'étique ça non ? <br>
Alors j'ai crée ce truc, je sais pas ce que j'en ferai, et vous non plus mais voilà c'est là.

## Fonctionnalités

- Sélectionner un fichier texte via une boîte de dialogue.
- Supprimer les doublons de mots dans le fichier.
- Enregistrer le résultat dans le même fichier.

## Prérequis

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)
- Visual Studio (pour compiler et exécuter le programme)

## Installation
1. Ouvrez le projet dans Visual Studio.

2. Choississez votre séparateur à la ligne : 39

2. Compilez et/ou exécutez le projet.

## Utilisation

1. Lancez l'application.
2. Cliquez sur le bouton "Select File" pour choisir un fichier texte à traiter.
3. Cliquez sur le bouton "Go" pour commencer le traitement.
4. Les doublons seront supprimés, et le fichier sera mis à jour avec les données nettoyées.

## Description du Code

- `buttonSelect_Click`: Ouvre une boîte de dialogue pour sélectionner le fichier texte à traiter.
- `buttonGo_Click`: Déclenche la méthode de suppression des doublons.
- `RemoveDuplicate`: Lit le fichier, supprime les doublons des mots, et enregistre le résultat dans le fichier.

## License
Concédé sous license (MIT)[https://github.com/Miiraak/RDFL/edit/master/LICENSE]

