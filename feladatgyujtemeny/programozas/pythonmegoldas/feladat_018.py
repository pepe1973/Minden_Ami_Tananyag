from turtle import *

def teglalap():
	begin_fill()
	forward(400)
	left(90)
	forward(100)
	left(90)
	forward(400)
	left(90)
	forward(100)
	end_fill()

reset()
color("black")
fillcolor("black")
teglalap()
up()
forward(100)
left(90)
down()
color("black")
fillcolor("red")
teglalap()
up()
forward(100)
left(90)
down()
color("black")
fillcolor("yellow")
teglalap()

done()