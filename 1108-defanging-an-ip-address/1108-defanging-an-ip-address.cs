public class Solution {
    public string DefangIPaddr(string address) {
        string[] arr=address.Split('.');
        var str = String.Join("[.]", arr);
        return str;
    }
}