left,right,t=input().split()
left=int(left)
right=int(right)
t=int(t)
a=list(float(range(left,right+1)))
def binary_search(left, right, t):
    k=1
    if left > right: return None
    mid = (left + right)/2
    if a[mid]==t:return k
    if a[mid] > t :
        k+=1
        binary_search(left,mid-1,t)
    else:
        k+=1
        binary_search(mid+1, right, t)
print(binary_search(left, right, t))


