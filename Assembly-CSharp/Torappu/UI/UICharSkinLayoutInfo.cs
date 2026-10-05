using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034F2 RID: 13554
	[Token(Token = "0x20034F2")]
	[CreateAssetMenu(menuName = "Torappu/UI/Character/SkinLayout")]
	[Serializable]
	public class UICharSkinLayoutInfo : ScriptableObject, IHotfixable
	{
		// Token: 0x0601599E RID: 88478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601599E")]
		[Address(RVA = "0xE3BC20", Offset = "0xE3A820", VA = "0x180E3BC20")]
		[Inspect]
		public void Bake()
		{
		}

		// Token: 0x0601599F RID: 88479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601599F")]
		[Address(RVA = "0xE3C2F0", Offset = "0xE3AEF0", VA = "0x180E3C2F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060159A0 RID: 88480 RVA: 0x0008CC58 File Offset: 0x0008AE58
		[Token(Token = "0x60159A0")]
		[Address(RVA = "0xE3BD90", Offset = "0xE3A990", VA = "0x180E3BD90")]
		private static bool _CheckIfContentChanged(Dictionary<string, UICharSkinLayoutInfo.Info> lhs, Dictionary<string, UICharSkinLayoutInfo.Info> rhs)
		{
			return default(bool);
		}

		// Token: 0x060159A1 RID: 88481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60159A1")]
		[Address(RVA = "0xE3C120", Offset = "0xE3AD20", VA = "0x180E3C120")]
		private Dictionary<string, UICharSkinLayoutInfo.Info> _GenIllustLayoutMap()
		{
			return null;
		}

		// Token: 0x060159A2 RID: 88482 RVA: 0x0008CC70 File Offset: 0x0008AE70
		[Token(Token = "0x60159A2")]
		[Address(RVA = "0xE3BC80", Offset = "0xE3A880", VA = "0x180E3BC80")]
		public UICharSkinLayoutInfo.Info GetLayoutInfo(string illustId)
		{
			return default(UICharSkinLayoutInfo.Info);
		}

		// Token: 0x060159A3 RID: 88483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60159A3")]
		[Address(RVA = "0xE3C520", Offset = "0xE3B120", VA = "0x180E3C520")]
		public UICharSkinLayoutInfo()
		{
		}

		// Token: 0x04019E75 RID: 106101
		[Token(Token = "0x4019E75")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> _illustIds;

		// Token: 0x04019E76 RID: 106102
		[Token(Token = "0x4019E76")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<UICharSkinLayoutInfo.Info> _infos;

		// Token: 0x04019E77 RID: 106103
		[Token(Token = "0x4019E77")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, UICharSkinLayoutInfo.Info> m_infoMap;

		// Token: 0x04019E78 RID: 106104
		[Token(Token = "0x4019E78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Bake;

		// Token: 0x04019E79 RID: 106105
		[Token(Token = "0x4019E79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04019E7A RID: 106106
		[Token(Token = "0x4019E7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfContentChanged;

		// Token: 0x04019E7B RID: 106107
		[Token(Token = "0x4019E7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenIllustLayoutMap;

		// Token: 0x04019E7C RID: 106108
		[Token(Token = "0x4019E7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetLayoutInfo;

		// Token: 0x04019E7D RID: 106109
		[Token(Token = "0x4019E7D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034F3 RID: 13555
		[Token(Token = "0x20034F3")]
		[Serializable]
		public struct Info
		{
			// Token: 0x060159A4 RID: 88484 RVA: 0x0008CC88 File Offset: 0x0008AE88
			[Token(Token = "0x60159A4")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x060159A5 RID: 88485 RVA: 0x0008CCA0 File Offset: 0x0008AEA0
			[Token(Token = "0x60159A5")]
			[Address(RVA = "0xE393B0", Offset = "0xE37FB0", VA = "0x180E393B0")]
			public static UICharSkinLayoutInfo.Info Create(Image image)
			{
				return default(UICharSkinLayoutInfo.Info);
			}

			// Token: 0x060159A6 RID: 88486 RVA: 0x0008CCB8 File Offset: 0x0008AEB8
			[Token(Token = "0x60159A6")]
			[Address(RVA = "0xE39520", Offset = "0xE38120", VA = "0x180E39520")]
			public bool Similar(UICharSkinLayoutInfo.Info other)
			{
				return default(bool);
			}

			// Token: 0x04019E7E RID: 106110
			[Token(Token = "0x4019E7E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UICharSkinLayoutInfo.Info EMPTY;

			// Token: 0x04019E7F RID: 106111
			[Token(Token = "0x4019E7F")]
			[FieldOffset(Offset = "0x0")]
			[JsonIgnore]
			private bool m_isEmpty;

			// Token: 0x04019E80 RID: 106112
			[Token(Token = "0x4019E80")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 pos;

			// Token: 0x04019E81 RID: 106113
			[Token(Token = "0x4019E81")]
			[FieldOffset(Offset = "0xC")]
			public float size;
		}
	}
}
