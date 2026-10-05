using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	public class SaveUIComponent : MonoBehaviour
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x5C30760", Offset = "0x5C2F360", VA = "0x185C30760")]
		private void Awake()
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x5C310D0", Offset = "0x5C2FCD0", VA = "0x185C310D0")]
		private void SaveFloat(float value)
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x5C30D10", Offset = "0x5C2F910", VA = "0x185C30D10")]
		private float LoadFloat(float defaultValue)
		{
			return 0f;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x5C310E0", Offset = "0x5C2FCE0", VA = "0x185C310E0")]
		private void SaveInt(int value)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x5C30D20", Offset = "0x5C2F920", VA = "0x185C30D20")]
		private int LoadInt(int defaultValue)
		{
			return 0;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x5C310F0", Offset = "0x5C2FCF0", VA = "0x185C310F0")]
		private void SaveString(string value)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x5C30D30", Offset = "0x5C2F930", VA = "0x185C30D30")]
		private string LoadString(string defaultValue)
		{
			return null;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x5C310B0", Offset = "0x5C2FCB0", VA = "0x185C310B0")]
		private void SaveBool(bool value)
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x5C30CF0", Offset = "0x5C2F8F0", VA = "0x185C30CF0")]
		private bool LoadBool(bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x5C30D40", Offset = "0x5C2F940", VA = "0x185C30D40")]
		private void OnValidate()
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public SaveUIComponent()
		{
		}

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string key;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIBehaviour target;
	}
}
