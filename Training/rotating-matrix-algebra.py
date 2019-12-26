import numpy as np

flat = np.arange(16).reshape((4, 4))
rotated90 = np.empty(16).reshape((4, 4))
rotated180 = np.empty(16).reshape((4, 4))
rotated270 = np.empty(16).reshape((4, 4))


for x in range(4):
    for y in reversed(range(4)):
        rotated90[x, abs(y - 3)] = flat[y, x]
        rotated180[abs(y-3), abs(x-3)] = flat[y, x]
        rotated270[abs(x-3), y] = flat[y, x]


print("0 degree \n", flat)
print("90 degree \n",rotated90)
print("180 degree \n",rotated180)
print("270 degree \n", rotated270)

'''
http://www.ambrsoft.com/Equations/Matrix/Matrix.htm

      (y, -x) 90
      (-x,-y) 180 
      (-y, x) 270      
'''
