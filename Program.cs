using System.Net;

// Create a List
class Branch {
    public List<Branch> branches;

    public Branch() {
        branches = new List<Branch>();
    }
}
class Program {
    public static void Main(string[] args) {
        // Create branch (DEPTH 1)
        Branch root = new Branch();
        
        Branch branch1 = new Branch();
        Branch branch2 = new Branch();
        Branch branch3 = new Branch();
        Branch branch4 = new Branch();
        Branch branch5 = new Branch();
        Branch branch6 = new Branch();
        Branch branch7 = new Branch();
        Branch branch8 = new Branch();
        Branch branch9 = new Branch();
        Branch branch10 = new Branch();

        // DEPTH 2
        root.branches.Add(branch1);
        root.branches.Add(branch2);
        // DEPTH 3
        branch1.branches.Add(branch3);
        branch2.branches.Add(branch4);
        branch2.branches.Add(branch5);
        branch2.branches.Add(branch6);
        // DEPTH 4
        branch4.branches.Add(branch7);
        branch5.branches.Add(branch8);
        branch5.branches.Add(branch9);
        // DEPTH 5
        branch8.branches.Add(branch10);

        // Recursive Function
        PrintBranches(root, 0);
        Console.ReadLine();
    }

    static void PrintBranches(Branch branch, int depth)
    {
        string printBr = new string(' ', depth * 4);
        Console.WriteLine(printBr + "Branch Depth " + depth);
        foreach (var b in branch.branches) {
            PrintBranches(b, depth + 1);
        }
    }
}





