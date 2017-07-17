# Syncity
Unity Project with Shaders

<hr>

<strong>Bugs</strong>

1.  Some of the materials don't render all of their shaders in thermal and EM vision modes, which use replacement shaders.  (Such as the door frames and particle effects.)  A possible solution is to assign subshader replacements for those shaders.

2.  By assigning a new shader to some renderers, they lose some of the details of their old shaders.  A possible solution is to edit the existing shaders to contain the necessary properties.

3.  There is a slight flicker in the scene.

<br>
<hr>
<br>

<strong>To Do</strong>

1.  Fix the bugs listed above.

2.  Remove the duplicate code created when the special vision was added.  The CameraController script shares code with the VisionCamera script.

3.  Improve some of the post-processing effects for better aesthetics.

<br>
<hr>
<br>

<strong>New Features</strong>

1.  Adding a UI with the controls shown.

2.  Adding camera movement.

3.  Adding more visual effects.
