using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D65 RID: 15717
	[Token(Token = "0x2003D65")]
	public class TemplateShopResourceBar : MonoBehaviour, IPlayerDataListener, IHotfixable
	{
		// Token: 0x06018799 RID: 100249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018799")]
		[Address(RVA = "0x10F9CD0", Offset = "0x10F88D0", VA = "0x1810F9CD0")]
		public void InitAndBind(string shopId)
		{
		}

		// Token: 0x0601879A RID: 100250 RVA: 0x0009A818 File Offset: 0x00098A18
		[Token(Token = "0x601879A")]
		[Address(RVA = "0x10F9B40", Offset = "0x10F8740", VA = "0x1810F9B40", Slot = "4")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0601879B RID: 100251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601879B")]
		[Address(RVA = "0x10F9FC0", Offset = "0x10F8BC0", VA = "0x1810F9FC0", Slot = "5")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0601879C RID: 100252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601879C")]
		[Address(RVA = "0x10FA020", Offset = "0x10F8C20", VA = "0x1810FA020")]
		private void _TryUpdateCoinCount()
		{
		}

		// Token: 0x0601879D RID: 100253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601879D")]
		[Address(RVA = "0x10F9F60", Offset = "0x10F8B60", VA = "0x1810F9F60")]
		private void OnEnable()
		{
		}

		// Token: 0x0601879E RID: 100254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601879E")]
		[Address(RVA = "0x10F9F00", Offset = "0x10F8B00", VA = "0x1810F9F00")]
		private void OnDisable()
		{
		}

		// Token: 0x0601879F RID: 100255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601879F")]
		[Address(RVA = "0x10F9EA0", Offset = "0x10F8AA0", VA = "0x1810F9EA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060187A0 RID: 100256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187A0")]
		[Address(RVA = "0x10FA190", Offset = "0x10F8D90", VA = "0x1810FA190")]
		public TemplateShopResourceBar()
		{
		}

		// Token: 0x0401DFAD RID: 122797
		[Token(Token = "0x401DFAD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Text _shopCoinCount;

		// Token: 0x0401DFAE RID: 122798
		[Token(Token = "0x401DFAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Image _shopCoinIcon;

		// Token: 0x0401DFAF RID: 122799
		[Token(Token = "0x401DFAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public Image _shopBarImage;

		// Token: 0x0401DFB0 RID: 122800
		[Token(Token = "0x401DFB0")]
		[FieldOffset(Offset = "0x30")]
		private string m_cacheShopId;

		// Token: 0x0401DFB1 RID: 122801
		[Token(Token = "0x401DFB1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitAndBind;

		// Token: 0x0401DFB2 RID: 122802
		[Token(Token = "0x401DFB2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0401DFB3 RID: 122803
		[Token(Token = "0x401DFB3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0401DFB4 RID: 122804
		[Token(Token = "0x401DFB4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryUpdateCoinCount;

		// Token: 0x0401DFB5 RID: 122805
		[Token(Token = "0x401DFB5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401DFB6 RID: 122806
		[Token(Token = "0x401DFB6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401DFB7 RID: 122807
		[Token(Token = "0x401DFB7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401DFB8 RID: 122808
		[Token(Token = "0x401DFB8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
