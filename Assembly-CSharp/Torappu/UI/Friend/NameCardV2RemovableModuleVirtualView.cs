using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DFB RID: 19963
	[Token(Token = "0x2004DFB")]
	public abstract class NameCardV2RemovableModuleVirtualView : NameCardV2MoudleVirtualView
	{
		// Token: 0x17004603 RID: 17923
		// (get) Token: 0x0601DD5B RID: 122203 RVA: 0x000AC770 File Offset: 0x000AA970
		[Token(Token = "0x17004603")]
		public int sortId
		{
			[Token(Token = "0x601DD5B")]
			[Address(RVA = "0x1778F30", Offset = "0x1777B30", VA = "0x181778F30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601DD5C RID: 122204
		[Token(Token = "0x601DD5C")]
		public abstract void PlaySelectTween(bool isShow);

		// Token: 0x0601DD5D RID: 122205
		[Token(Token = "0x601DD5D")]
		public abstract void ResetSelectTween(bool isShow);

		// Token: 0x0601DD5E RID: 122206
		[Token(Token = "0x601DD5E")]
		public abstract void SetHidenOption(Action onHiden);

		// Token: 0x0601DD5F RID: 122207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD5F")]
		[Address(RVA = "0x1778E80", Offset = "0x1777A80", VA = "0x181778E80")]
		protected NameCardV2RemovableModuleVirtualView()
		{
		}

		// Token: 0x04027883 RID: 161923
		[Token(Token = "0x4027883")]
		[FieldOffset(Offset = "0x20")]
		protected int m_sortId;

		// Token: 0x04027884 RID: 161924
		[Token(Token = "0x4027884")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04027885 RID: 161925
		[Token(Token = "0x4027885")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
