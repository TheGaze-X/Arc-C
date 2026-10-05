using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Interactions
{
	// Token: 0x02000224 RID: 548
	[Token(Token = "0x2000224")]
	[DisplayName("Press")]
	public class PressInteraction : IInputInteraction
	{
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x170005B3")]
		private float pressPointOrDefault
		{
			[Token(Token = "0x60013FB")]
			[Address(RVA = "0x560C020", Offset = "0x560AC20", VA = "0x18560C020")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x170005B4")]
		private float releasePointOrDefault
		{
			[Token(Token = "0x60013FC")]
			[Address(RVA = "0x560C070", Offset = "0x560AC70", VA = "0x18560C070")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x560BE60", Offset = "0x560AA60", VA = "0x18560BE60", Slot = "4")]
		public void Process(ref InputInteractionContext context)
		{
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x5422FE0", Offset = "0x5421BE0", VA = "0x185422FE0", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PressInteraction()
		{
		}

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("The amount of actuation a control requires before being considered pressed. If not set, default to 'Default Press Point' in the global input settings.")]
		public float pressPoint;

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("Determines how button presses trigger the action. By default (PressOnly), the action is performed on press. With ReleaseOnly, the action is performed on release. With PressAndRelease, the action is performed on press and release.")]
		public PressBehavior behavior;

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x18")]
		private bool m_WaitingForRelease;
	}
}
