# C# 8.0 nullable reference issue

## Steps to reproduce

Run command: `dotnet build CS8Null.sln -c Release`

### Actual behavior

No warning

### Expected behavior

Warning CS8602 in file ClientProj\ClientClass.cs (line 18) about dereferencing of possible null reference.

## Details

### BaseProj

**BaseProj** has enabled nullable context. `GetRefObject(int)` method returns nullable reference. Then in project **ClientProj** it is necessary to use null-conditional operator, otherwise compiler reports warning about dereferencing possible null reference CS8602.

### MidProj

**MidProj** has disabled nullable context. `GetRefObject(int)` method returns _oblivious_ nullable type. However, in **ClientProj** result is assigned to variable that is explicitly declared as nullable type `RefObject? midRef`. And yet there is no warning CS8602, when the variable is dereferenced.
