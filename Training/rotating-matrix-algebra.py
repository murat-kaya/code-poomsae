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

#### OUTPUT #####

0 degree 
 [[ 0  1  2  3]
 [ 4  5  6  7]
 [ 8  9 10 11]
 [12 13 14 15]]
 
90 degree 
 [[12.  8.  4.  0.]
 [13.  9.  5.  1.]
 [14. 10.  6.  2.]
 [15. 11.  7.  3.]]
 
180 degree 
 [[15. 14. 13. 12.]
 [11. 10.  9.  8.]
 [ 7.  6.  5.  4.]
 [ 3.  2.  1.  0.]]
 
270 degree 
 [[ 3.  7. 11. 15.]
 [ 2.  6. 10. 14.]
 [ 1.  5.  9. 13.]
 [ 0.  4.  8. 12.]]
 
'''

