using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020037C1 RID: 14273
	[Token(Token = "0x20037C1")]
	public class UI3DLayoutAdapter : MonoBehaviour, ISafeAreaListener
	{
		// Token: 0x06016A01 RID: 92673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A01")]
		[Address(RVA = "0xF0D540", Offset = "0xF0C140", VA = "0x180F0D540")]
		private void Start()
		{
		}

		// Token: 0x06016A02 RID: 92674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A02")]
		[Address(RVA = "0xF0D360", Offset = "0xF0BF60", VA = "0x180F0D360")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016A03 RID: 92675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A03")]
		[Address(RVA = "0xF0D3B0", Offset = "0xF0BFB0", VA = "0x180F0D3B0", Slot = "4")]
		public void OnSafeRectUpdated(SafeRect rect)
		{
		}

		// Token: 0x06016A04 RID: 92676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A04")]
		[Address(RVA = "0xF0D590", Offset = "0xF0C190", VA = "0x180F0D590")]
		private void _AdjustLayout(Vector2 resolution)
		{
		}

		// Token: 0x06016A05 RID: 92677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A05")]
		[Address(RVA = "0xF0D250", Offset = "0xF0BE50", VA = "0x180F0D250")]
		public static void CalcLayoutBoundaries(bool isForceUpdate)
		{
		}

		// Token: 0x06016A06 RID: 92678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016A06")]
		[Address(RVA = "0xF0D6F0", Offset = "0xF0C2F0", VA = "0x180F0D6F0")]
		private static string _ConvertGraphicUtilName(string fieldName, string code1, string code2)
		{
			return null;
		}

		// Token: 0x06016A07 RID: 92679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A07")]
		[Address(RVA = "0xF0D810", Offset = "0xF0C410", VA = "0x180F0D810")]
		public UI3DLayoutAdapter()
		{
		}

		// Token: 0x0401B465 RID: 111717
		[Token(Token = "0x401B465")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIVector3Lerp[] _targets;

		// Token: 0x0401B466 RID: 111718
		[Token(Token = "0x401B466")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _fromResolution;

		// Token: 0x0401B467 RID: 111719
		[Token(Token = "0x401B467")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _toResolution;

		// Token: 0x0401B468 RID: 111720
		[Token(Token = "0x401B468")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("To adjust IPad, use FIT_HEIGHT; while for IphoneX use FIT_WIDTH")]
		private AdapterUtil.FitMode _fitMode;

		// Token: 0x0401B469 RID: 111721
		[Token(Token = "0x401B469")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector2 _testResolution;
	}
}
