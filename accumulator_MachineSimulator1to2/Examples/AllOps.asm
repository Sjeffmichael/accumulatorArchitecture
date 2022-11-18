;Variable que se opera 4 veces
.data
load 2
store A
load 2 
store B
load 0
store C

.code
load C
add A
store C

load C
mul B
store C

load C
div A
store C

load C
sub B
store C
