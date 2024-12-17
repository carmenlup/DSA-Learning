def print_diagonal(x, y, mat):
    """
    Extracts and returns the diagonal elements of a 2D matrix starting from a given position.
    Args:
        x (int): The starting row index.
        y (int): The starting column index.
        mat (list of list of int): The 2D matrix from which to extract the diagonal.
    Returns:
        list of int: A list containing the diagonal elements starting from (x, y) and moving downwards to the left.
    """
    n = len(mat)
    i = x
    j = y
    arr = []
    while i < n and j >= 0:
        arr.append(mat[i][j])
        i += 1
        j -= 1
    return arr
    # for i in range(x,n):
    #     for j in range(y,m):
    #         print(mat[i][j])


print_diagonal(0, 1, [[1, 2, 3], [4, 5, 6], [7, 8, 9]])


def print_all_diagonals(mat):
    n = len(mat)
    m = len(mat[0])
    for j in range(m):
      # print(arr.append(print_Diagonal(0,j,mat)))
        print(print_diagonal(0, j, mat))
    for i in range(1, n):
      # print(arr.append(print_Diagonal(i,n-1,mat)))
        print(print_diagonal(i, n-1, mat))

# [[1,2,3],
#  [4,5,6],
#  [7,8,9]]


print_all_diagonals([[1, 2, 3], [4, 5, 6], [7, 8, 9]])


def diagonal(A):
    # r = len(A)
    # c = len(A[0])
    N = len(A)
    ans = [[0 for j in range(N)] for i in range(2*N-1)]
    for i in range(N):
        for j in range(N):
            ans[i+j][i] = A[i][j]
    print(ans)


print(diagonal([[1, 2, 3], [4, 5, 6], [7, 8, 9]]))
