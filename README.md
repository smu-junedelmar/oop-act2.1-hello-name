# 🚀 Activity 2.1: Hello your_name!

## 🎯 Objective
- Practice reading **user input** and showing a **personalized greeting**.  
- Learn the basic **GitHub Classroom workflow**: clone ➝ edit ➝ commit ➝ push.

---

## 🛠️ Prerequisites
Before you start, make sure you have the following installed on your computer:

- [📦 .NET 8 SDK](https://dotnet.microsoft.com/en-us/download)  
  *(needed to run and build C# programs)*  
- [📝 Visual Studio Code](https://code.visualstudio.com/) **or** [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)  
  *(choose either editor — VS Code is lightweight, VS 2022 is full-featured)*  
- [🐙 Git](https://git-scm.com/downloads)  
  *(used for cloning, committing, and pushing your code to GitHub Classroom)*  
- A GitHub account (already linked to your **Classroom repo**)

---

## 🧭 Getting Started: Clone & Open the Repository

> You can use **Visual Studio Code** *or* **Visual Studio 2022**. Pick one option below.

### Option A — Visual Studio Code (GUI)
1. Copy your **GitHub Classroom repo URL** from the assignment page. It looks like:  
   `https://github.com/<org>/<repo-name>`
2. Open **VS Code** → **View ▸ Command Palette…** → type **“Git: Clone”** → **Git: Clone**.  
3. Paste the repo URL → choose a local folder where VS Code will save the repo.  
4. When prompted **“Open the cloned repository?”**, click **Open**.  
5. If prompted to install extensions, install **C# Dev Kit** and **.NET Runtime** helpers.

### Option A.1 — Visual Studio Code (Terminal)
1. Open **Terminal** (Command Prompt/PowerShell on Windows, Terminal on macOS/Linux).  
2. Run:
   ```bash
   git clone <YOUR_REPO_URL>
   cd <YOUR_REPO_NAME>
   code .
   ```
   VS Code opens the folder.

### Option B — Visual Studio 2022 (Windows)
1. Open **Visual Studio 2022**.  
2. On the start window, click **Clone a repository**.  
3. Paste your **repo URL**, choose a **local path**, then click **Clone**.  
4. After cloning:
   - If the repo has a **solution (.sln)**, it will appear—open it.  
   - If there’s **no .sln**, click **File ▸ Open ▸ Folder…** and select the repo root folder.

> ℹ️ On macOS, prefer **VS Code** (Visual Studio for Mac is retired).

---

## 📝 Task
- You only need to **update the code inside**:  
  ```
  HelloName/Program.cs
  ```

✅ Ask the user to type their **first name**.  
✅ Print a greeting message using that name.  

⚠️ Do **not** change any other files. The automated tests depend on the structure of the repository.  

---

## ▶️ Run the Program Locally

### In Visual Studio Code
1. Open an integrated terminal (**Terminal ▸ New Terminal**).  
2. Run the project (from the repo root):
   ```bash
   dotnet run --project HelloName
   ```
3. Type a name and press **Enter**. You should see the greeting.

### In Visual Studio 2022
1. In **Solution Explorer** (or Folder View), make sure the **HelloName** project is selected.  
2. Set it as startup if needed (right‑click **HelloName** → **Set as Startup Project**).  
3. Run with **Start Without Debugging** (**Ctrl+F5**) or **Start Debugging** (**F5**).  
4. Type a name in the console and press **Enter**.

---

## ⌨️ Input
- Your **first name**

---

## 🖥️ Example Run
**Input:**  
```
Juswa
```

**Output:**  
```
Hello, Juswa!
```

---

## 📤 Submit Your Work (Commit & Push)

### Using Visual Studio Code (Source Control)
1. Click the **Source Control** icon (left sidebar).  
2. You should see `HelloName/Program.cs` as a change.  
3. Enter a message (e.g., `Complete Activity 2.1`) and click **Commit**.  
4. Click **Sync/Push** (or **… ▸ Push**).

### Using Terminal (any editor)
```bash
git status
git add HelloName/Program.cs
git commit -m "Complete Activity 2.1 - Hello your_name!"
git push origin main
```
> If your default branch is `master`, replace `main` with `master`.

---

## ✅ Verify Submission
1. Go to your GitHub repo page.  
2. Open the **Actions** tab.  
3. Wait for the workflow to run.  
   - **Green check** = passed tests.  
   - **Red X** = failed tests (click the run to read feedback and fix your code).

---

## 🧪 What Is Auto-Checked?
- Your program reads one line as a **name**.  
- Your program prints exactly:  
  ```
  Hello, <name>!
  ```
  (e.g., `Hello, Juswa!`)  
- Extra prompts like `Enter your name:` may cause tests to fail.

---

## 🆘 Troubleshooting
- **`dotnet` not recognized** → install **.NET 8 SDK**, then restart your editor.  
- **Build errors** → run `dotnet build` and read the first error listed.  
- **Push rejected** → do `git pull` first, resolve any conflicts, then push.  
- **Wrong branch** → ensure you push to **main** (or your classroom’s required branch).
