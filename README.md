# Générateur de mots de passe en C#

Ce projet est un exercice de formation réalisé dans le cadre de mon apprentissage en programmation avec C#. Il s'agit d'un simple générateur de mots de passe qui offre plusieurs options pour personnaliser les mots de passe générés.

## Fonctionnalités

- Génération de mots de passe avec différentes options :
  1. Lettres minuscules uniquement.
  2. Lettres minuscules et majuscules.
  3. Lettres minuscules, majuscules et chiffres.
  4. Lettres minuscules, majuscules, chiffres et caractères spéciaux.
- Possibilité de définir la longueur des mots de passe.
- Génération de plusieurs mots de passe en une seule fois.

## Objectif du projet

Ce projet est conçu pour pratiquer les bases du langage C#, notamment :
- Les boucles `for`.
- Les structures de contrôle `switch` et `try-catch`.
- L'utilisation de méthodes pour structurer le code.
- La manipulation des chaînes de caractères.
- L'utilisation de la classe `Random`.

## Comment exécuter le projet

1. Clonez ce dépôt ou copiez le code dans votre IDE C# (comme Visual Studio ou Rider).
2. Assurez-vous d'avoir .NET installé sur votre système.
3. Compilez et exécutez le programme.
4. Suivez les instructions dans la console pour choisir les options de génération et spécifier la longueur des mots de passe.

## Exemple d'utilisation

Après avoir démarré le programme :
1. Vous serez invité à choisir une option pour le type de caractères dans le mot de passe.
2. Vous définirez la longueur des mots de passe.
3. Le programme générera 4 mots de passe (ou plus si modifié dans le code).

### Exemple de sortie console

Longueur du mot de passe : 8 Choisissez une option de génération de mots de passe : 1 - Lettres en minuscules 2 - Lettres minuscules et majuscules 3 - Lettres minuscules, majuscules et chiffres 4 - Lettres minuscules, majuscules, chiffres et caractères spéciaux Option : 3

Mots de passe générés : qW3eRtY1 aS2dFgH3 zX4cVbN9 wQ1eRtY2

## Limitations connues

- Le programme génère les mots de passe en boucle mais utilise une instance de `Random` dans chaque itération, ce qui peut entraîner des résultats non optimaux en termes d'aléatoire.
- Le nombre de mots de passe générés est actuellement fixé à 4 dans le code (modifiable via la variable `nbPassword`).
- La validation des entrées utilisateur pourrait être améliorée.

## À propos

Ce projet a été réalisé dans le cadre d'un apprentissage personnel en programmation avec C#. Il n'est pas destiné à un usage en production, mais uniquement à des fins éducatives.

---

**Technologies utilisées :**
- C#
- .NET Core

**Auteur :** IAmRom1  
