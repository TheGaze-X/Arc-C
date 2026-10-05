using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200428C RID: 17036
	[Token(Token = "0x200428C")]
	public abstract class SandboxV2DungeonPushMessageElement : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A3F8 RID: 107512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A3F8")]
		[Address(RVA = "0x133A890", Offset = "0x1339490", VA = "0x18133A890")]
		private void OnEnable()
		{
		}

		// Token: 0x0601A3F9 RID: 107513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A3F9")]
		[Address(RVA = "0x133A7D0", Offset = "0x13393D0", VA = "0x18133A7D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601A3FA RID: 107514
		[Token(Token = "0x601A3FA")]
		public abstract void SetShowStatus(SandboxV2DungeonPushMessageElement.ShowParam showParam);

		// Token: 0x0601A3FB RID: 107515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A3FB")]
		[Address(RVA = "0x133A9F0", Offset = "0x13395F0", VA = "0x18133A9F0")]
		protected SandboxV2DungeonPushMessageElement()
		{
		}

		// Token: 0x040213AF RID: 136111
		[Token(Token = "0x40213AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<SandboxV2DungeonPushMessageObservableType> _enableObservables;

		// Token: 0x040213B0 RID: 136112
		[Token(Token = "0x40213B0")]
		[FieldOffset(Offset = "0x20")]
		private SandboxV2DungeonPushMessageController m_pushMessageController;

		// Token: 0x040213B1 RID: 136113
		[Token(Token = "0x40213B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x040213B2 RID: 136114
		[Token(Token = "0x40213B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040213B3 RID: 136115
		[Token(Token = "0x40213B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200428D RID: 17037
		[Token(Token = "0x200428D")]
		public class ShowParam
		{
			// Token: 0x0601A3FC RID: 107516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A3FC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShowParam()
			{
			}

			// Token: 0x040213B4 RID: 136116
			[Token(Token = "0x40213B4")]
			[FieldOffset(Offset = "0x10")]
			public bool isShow;

			// Token: 0x040213B5 RID: 136117
			[Token(Token = "0x40213B5")]
			[FieldOffset(Offset = "0x11")]
			public bool isFastMode;

			// Token: 0x040213B6 RID: 136118
			[Token(Token = "0x40213B6")]
			[FieldOffset(Offset = "0x14")]
			public SandboxV2DungeonPushMessageObservableType observableType;

			// Token: 0x040213B7 RID: 136119
			[Token(Token = "0x40213B7")]
			[FieldOffset(Offset = "0x18")]
			public object param;
		}
	}
}
