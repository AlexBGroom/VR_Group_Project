using UnityEngine;
using System.Collections.Generic;

public interface IScannable
{
    public void Scan(List<SecurityCardSO> cardList);
}

public class DeclareScannable : MonoBehaviour
{
    
}
