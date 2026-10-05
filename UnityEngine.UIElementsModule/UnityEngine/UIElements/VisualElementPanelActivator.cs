using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	internal class VisualElementPanelActivator
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x000047E8 File Offset: 0x000029E8
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013F")]
		public bool isActive
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00004800 File Offset: 0x00002A00
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000140")]
		public bool isDetaching
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public VisualElementPanelActivator(IVisualElementPanelActivatable activatable)
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x5AA1330", Offset = "0x5A9FF30", VA = "0x185AA1330")]
		public void SetActive(bool action)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x5AA1250", Offset = "0x5A9FE50", VA = "0x185AA1250")]
		public void SendActivation()
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x5AA12C0", Offset = "0x5A9FEC0", VA = "0x185AA12C0")]
		public void SendDeactivation()
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x5AA11E0", Offset = "0x5A9FDE0", VA = "0x185AA11E0")]
		private void OnEnter(AttachToPanelEvent evt)
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x5AA11F0", Offset = "0x5A9FDF0", VA = "0x185AA11F0")]
		private void OnLeave(DetachFromPanelEvent evt)
		{
		}

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x10")]
		private IVisualElementPanelActivatable m_Activatable;
	}
}
