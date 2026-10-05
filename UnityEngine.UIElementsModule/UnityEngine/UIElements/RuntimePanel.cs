using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	internal class RuntimePanel : BaseRuntimePanel
	{
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000319")]
		public PanelSettings panelSettings
		{
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x5B12900", Offset = "0x5B11500", VA = "0x185B12900")]
		public static RuntimePanel Create(ScriptableObject ownerObject)
		{
			return null;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x5B12A50", Offset = "0x5B11650", VA = "0x185B12A50")]
		private RuntimePanel(ScriptableObject ownerObject)
		{
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x5B12960", Offset = "0x5B11560", VA = "0x185B12960", Slot = "50")]
		public override void Update()
		{
		}

		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly EventDispatcher s_EventDispatcher;

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x1D8")]
		private readonly PanelSettings m_PanelSettings;
	}
}
