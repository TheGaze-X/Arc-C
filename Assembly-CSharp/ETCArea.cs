using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002E RID: 46
[Token(Token = "0x200002E")]
[Serializable]
public class ETCArea : MonoBehaviour
{
	// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x4F9260", Offset = "0x4F7E60", VA = "0x1804F9260")]
	public ETCArea()
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x4F9200", Offset = "0x4F7E00", VA = "0x1804F9200")]
	public void Awake()
	{
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x4F8280", Offset = "0x4F6E80", VA = "0x1804F8280")]
	public void ApplyPreset(ETCArea.AreaPreset preset)
	{
	}

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x18")]
	public bool show;

	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public enum AreaPreset
	{
		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		Choose,
		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		TopLeft,
		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		TopRight,
		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		BottomLeft,
		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		BottomRight
	}
}
