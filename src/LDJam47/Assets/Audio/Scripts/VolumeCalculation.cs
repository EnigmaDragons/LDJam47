
using UnityEngine;

public static class VolumeCalculation
{
    public static float GetVolumeDecibels(float scalar, float reductionDb)
        => scalar > 0 ? (Mathf.Log10(scalar) * 20) - reductionDb : -120;
}
