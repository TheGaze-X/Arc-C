using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003A6E RID: 14958
	[Token(Token = "0x2003A6E")]
	public struct UICompDialogFinder
	{
		// Token: 0x06017A6C RID: 96876 RVA: 0x000978A8 File Offset: 0x00095AA8
		[Token(Token = "0x6017A6C")]
		[Address(RVA = "0xFF1FE0", Offset = "0xFF0BE0", VA = "0x180FF1FE0")]
		public UICompDialogFinder.Interface Current(MonoBehaviour current)
		{
			return default(UICompDialogFinder.Interface);
		}

		// Token: 0x06017A6D RID: 96877 RVA: 0x000978C0 File Offset: 0x00095AC0
		[Token(Token = "0x6017A6D")]
		[Address(RVA = "0xFF2070", Offset = "0xFF0C70", VA = "0x180FF2070")]
		public UICompDialogFinder.Interface Current(Transform current)
		{
			return default(UICompDialogFinder.Interface);
		}

		// Token: 0x0401C8AA RID: 116906
		[Token(Token = "0x401C8AA")]
		[FieldOffset(Offset = "0x0")]
		private UICompDialogMgr.DialogBase m_dialog;

		// Token: 0x0401C8AB RID: 116907
		[Token(Token = "0x401C8AB")]
		[FieldOffset(Offset = "0x8")]
		private Transform m_curTrans;

		// Token: 0x02003A6F RID: 14959
		[Token(Token = "0x2003A6F")]
		public struct Interface
		{
			// Token: 0x06017A6E RID: 96878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A6E")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public Interface(UICompDialogMgr.DialogBase dialog)
			{
			}

			// Token: 0x06017A6F RID: 96879 RVA: 0x000978D8 File Offset: 0x00095AD8
			[Token(Token = "0x6017A6F")]
			[Address(RVA = "0xFEA5E0", Offset = "0xFE91E0", VA = "0x180FEA5E0")]
			public bool IsSameCompDialog(UICompDialogMgr.DialogBase comparsion)
			{
				return default(bool);
			}

			// Token: 0x06017A70 RID: 96880 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A70")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			public ILoadAsset GetAssetLoader()
			{
				return null;
			}

			// Token: 0x06017A71 RID: 96881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A71")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			public UnityEngine.Object UICompDialogHost()
			{
				return null;
			}

			// Token: 0x06017A72 RID: 96882 RVA: 0x000978F0 File Offset: 0x00095AF0
			[Token(Token = "0x6017A72")]
			public bool SendMessage<DialogType>(int key, ValueBundle msg) where DialogType : UICompDialogMgr.DialogBase, IValueMsgReceiver
			{
				return default(bool);
			}

			// Token: 0x06017A73 RID: 96883 RVA: 0x00097908 File Offset: 0x00095B08
			[Token(Token = "0x6017A73")]
			public bool SendMessage<DialogType>(int key) where DialogType : UICompDialogMgr.DialogBase, IValueMsgReceiver
			{
				return default(bool);
			}

			// Token: 0x06017A74 RID: 96884 RVA: 0x00097920 File Offset: 0x00095B20
			[Token(Token = "0x6017A74")]
			[Address(RVA = "0xFEA640", Offset = "0xFE9240", VA = "0x180FEA640")]
			public bool IsTransiting()
			{
				return default(bool);
			}

			// Token: 0x0401C8AC RID: 116908
			[Token(Token = "0x401C8AC")]
			[FieldOffset(Offset = "0x0")]
			private UICompDialogMgr.DialogBase m_dialog;
		}
	}
}
