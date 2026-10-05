using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059E3 RID: 23011
	[Token(Token = "0x20059E3")]
	public class CrisisV2RuneSelectInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004EC6 RID: 20166
		// (get) Token: 0x0602186E RID: 137326 RVA: 0x000BA918 File Offset: 0x000B8B18
		[Token(Token = "0x17004EC6")]
		public float preferredHeight
		{
			[Token(Token = "0x602186E")]
			[Address(RVA = "0x1BDD390", Offset = "0x1BDBF90", VA = "0x181BDD390")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602186F RID: 137327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602186F")]
		[Address(RVA = "0x1BDCA10", Offset = "0x1BDB610", VA = "0x181BDCA10")]
		public void Render(ICrisisV2RuneSingleItemInfo info)
		{
		}

		// Token: 0x06021870 RID: 137328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021870")]
		[Address(RVA = "0x1BDCF10", Offset = "0x1BDBB10", VA = "0x181BDCF10")]
		public void SetDescFocusType(bool focus)
		{
		}

		// Token: 0x06021871 RID: 137329 RVA: 0x000BA930 File Offset: 0x000B8B30
		[Token(Token = "0x6021871")]
		[Address(RVA = "0x1BDD130", Offset = "0x1BDBD30", VA = "0x181BDD130")]
		private CrisisV2RuneSingleItmePointLvType _GetPointLvType(int point)
		{
			return CrisisV2RuneSingleItmePointLvType.NONE;
		}

		// Token: 0x06021872 RID: 137330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021872")]
		[Address(RVA = "0x1BDD200", Offset = "0x1BDBE00", VA = "0x181BDD200")]
		private void _RegisterTutorialGo(ICrisisV2RuneSingleItemInfo info)
		{
		}

		// Token: 0x06021873 RID: 137331 RVA: 0x000BA948 File Offset: 0x000B8B48
		[Token(Token = "0x6021873")]
		[Address(RVA = "0x1BDD080", Offset = "0x1BDBC80", VA = "0x181BDD080")]
		private Color _GetPointLvCol(CrisisV2RuneSingleItmePointLvType pointLvType)
		{
			return default(Color);
		}

		// Token: 0x06021874 RID: 137332 RVA: 0x000BA960 File Offset: 0x000B8B60
		[Token(Token = "0x6021874")]
		[Address(RVA = "0x1BDCFE0", Offset = "0x1BDBBE0", VA = "0x181BDCFE0")]
		private float _CalcHeight(string desc)
		{
			return 0f;
		}

		// Token: 0x06021875 RID: 137333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021875")]
		[Address(RVA = "0x1BDD330", Offset = "0x1BDBF30", VA = "0x181BDD330")]
		public CrisisV2RuneSelectInfoItemView()
		{
		}

		// Token: 0x0402DD00 RID: 187648
		[Token(Token = "0x402DD00")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402DD01 RID: 187649
		[Token(Token = "0x402DD01")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgPoint;

		// Token: 0x0402DD02 RID: 187650
		[Token(Token = "0x402DD02")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x0402DD03 RID: 187651
		[Token(Token = "0x402DD03")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Color")]
		private Color _textColorFocus;

		// Token: 0x0402DD04 RID: 187652
		[Token(Token = "0x402DD04")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Color")]
		private Color _textColorUnFocus;

		// Token: 0x0402DD05 RID: 187653
		[Token(Token = "0x402DD05")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Color")]
		private Color _textColorPointLow;

		// Token: 0x0402DD06 RID: 187654
		[Token(Token = "0x402DD06")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Color")]
		private Color _textColorPointMiddle;

		// Token: 0x0402DD07 RID: 187655
		[Token(Token = "0x402DD07")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Color")]
		private Color _textColorPointHigh;

		// Token: 0x0402DD08 RID: 187656
		[Token(Token = "0x402DD08")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelHighLight;

		// Token: 0x0402DD09 RID: 187657
		[Token(Token = "0x402DD09")]
		[FieldOffset(Offset = "0x88")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402DD0A RID: 187658
		[Token(Token = "0x402DD0A")]
		[FieldOffset(Offset = "0x90")]
		private string m_desc;

		// Token: 0x0402DD0B RID: 187659
		[Token(Token = "0x402DD0B")]
		[FieldOffset(Offset = "0x98")]
		private float m_descHeight;

		// Token: 0x0402DD0C RID: 187660
		[Token(Token = "0x402DD0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0402DD0D RID: 187661
		[Token(Token = "0x402DD0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DD0E RID: 187662
		[Token(Token = "0x402DD0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetDescFocusType;

		// Token: 0x0402DD0F RID: 187663
		[Token(Token = "0x402DD0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetPointLvType;

		// Token: 0x0402DD10 RID: 187664
		[Token(Token = "0x402DD10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x0402DD11 RID: 187665
		[Token(Token = "0x402DD11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetPointLvCol;

		// Token: 0x0402DD12 RID: 187666
		[Token(Token = "0x402DD12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalcHeight;

		// Token: 0x0402DD13 RID: 187667
		[Token(Token = "0x402DD13")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
