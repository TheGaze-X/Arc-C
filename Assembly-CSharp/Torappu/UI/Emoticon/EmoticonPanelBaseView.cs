using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050D9 RID: 20697
	[Token(Token = "0x20050D9")]
	public abstract class EmoticonPanelBaseView : DataBinder<EmoticonPanelProperty>
	{
		// Token: 0x0601E9AC RID: 125356
		[Token(Token = "0x601E9AC")]
		protected abstract void _Render(EmoticonPanelBaseModel baseModel);

		// Token: 0x0601E9AD RID: 125357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9AD")]
		[Address(RVA = "0x183C240", Offset = "0x183AE40", VA = "0x18183C240", Slot = "9")]
		public virtual void Init(ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601E9AE RID: 125358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9AE")]
		[Address(RVA = "0x183C2C0", Offset = "0x183AEC0", VA = "0x18183C2C0", Slot = "7")]
		public override void OnValueChanged(EmoticonPanelProperty property)
		{
		}

		// Token: 0x0601E9AF RID: 125359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9AF")]
		[Address(RVA = "0x183C370", Offset = "0x183AF70", VA = "0x18183C370")]
		protected EmoticonPanelBaseView()
		{
		}

		// Token: 0x04029036 RID: 167990
		[Token(Token = "0x4029036")]
		[FieldOffset(Offset = "0x20")]
		protected ILoadAsset m_cachedAssetLoader;

		// Token: 0x04029037 RID: 167991
		[Token(Token = "0x4029037")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04029038 RID: 167992
		[Token(Token = "0x4029038")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04029039 RID: 167993
		[Token(Token = "0x4029039")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
