# Building a fully automated escape room - Tomas Vaskevicius
Automation is a good and cost-effective things. But it is not always a good answer. In this talk, Tomas talks about this prospect of how automation could be applied to an escape room, but also what the risks of fully automating one might bring.

## Why would we automate an escape room?
### As an owner
There are several systems in an escape room that would benefit from automation.
Communication is one part of this. This includes reservations, reminders, payment processing.
It can also help with asset management and cleaning up after a session. Like resetting automatic locks and collecting certain props.
Finally, a fully automated escape room might be an attraction for new players.

### As a player
Automation of an escape room could drive the price down as less manpower is required to run these. This might make it more attractive to do more often. It also might be a challenge to assemble enough friends to do a certain room. In this case, an automated room could be adjusted to the amount of players.
For a player, it's important to find a balance between challenging escape rooms and fun escape rooms. We don't want rooms that are too easy, as they pose no challenge. But we do not also want too much of a challenge, or we could leave the room feeling dumb.

Automation is (not) always the answer.

## How would an automated escape room work?
In this section, we work with a couple of features. These include:
- Registration service
- Reservation service
- Game center
- Game engine

### Online reservations
There is a portion before a game where the player has to register and make a reservation for a certain room.
These can be automated in the form of a website. When a player registers and reserves a room, then the game center of the room could reset the room before the player arrives. This is purely done by the online system.

### During a game
As a player, you would most likely only interact with the game center and the game engine. This would include automatically opening the door on the hour of reservation, but also interacting with the game's gateway. This gateway exists of screens, buttons, levers, etc... All physical interactions.

Through the actions of the player, the game engine could send status updates as well as alerts to the admin of the system. This way, if something goes wrong, the admin is automatically notified and they could interact with the game engine through remote control.

The game engine could consist of multiple modules:
- Speech module: This could play audio cues, voicelines and tips through speakers
- Puzzles module: This would be the entrypoint, controllers and exit point of the system. All interactions that trigger something in a puzzle
- Hint module: This works together with the puzzles and/or speech module. Hints could be pre-made or generated on the spot by using a language model like ChatGPT
- Session module: Keeps track of the progress of the puzzle
- Heartbeat module: Together with the session module, this can inform the admin of changes or problems during the game.

These modules can work independently or together to create unique experiences in an escape room.

## What are the risks and challenges of full automation
Like everything in life, technology might fail. If this were to happen before or during a game, then there needs to be a system in place to fall back to. The same can be said if the system would require an online connection and that connection should disappear.

If we want to use the player's voice for some puzzles, then the speech technology should not fail. Reasons it could fail include dialect, disabilities, different speech patterns, etc...

Say we were to use ChatGPT for hints. There is a risk that if a player notices they're dealing with an AI, that they might phrase the questions in a way that the AI would give an answer. A solution to this could be to pre-make the hints so that they are not generated on the spot.

A human behaviour is that we still want something physical in escape rooms. This includes props like keys, hints on paper, etc...
Right now, there is no simple way that when a room needs to be reset, that they could be placed back in the place of origin. Having props might also be an expensive endeavour. A solution for this could be to not use props, but this could make the room feel dull and boring.

## Summary
A fully automated escape room sounds like a fun idea, but we have to consider the possibility of malfunction in the system. In this case we need to have fallbacks for all the problems we might encounter which is not the easiest or cheapest to do.

Integration with AI tools sound promising for puzzles as well, but it might require more fine-tuning as AI can still be unpredictable.

All in all, automation might be a good thing as well as a fun thing. But that does not mean that we should only rely on automation.
