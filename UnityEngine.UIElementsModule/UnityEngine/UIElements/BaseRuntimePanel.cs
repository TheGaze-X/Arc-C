using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	internal abstract class BaseRuntimePanel : Panel
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		public GameObject selectableGameObject
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x4FA1A60", Offset = "0x4FA0660", VA = "0x184FA1A60", Slot = "51")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x5A24F00", Offset = "0x5A23B00", VA = "0x185A24F00", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00002AD8 File Offset: 0x00000CD8
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		public float sortingPriority
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x58BE310", Offset = "0x58BCF10", VA = "0x1858BE310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x5A24FB0", Offset = "0x5A23BB0", VA = "0x185A24FB0")]
			set
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		public event Action destroyed
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x5A24A80", Offset = "0x5A23680", VA = "0x185A24A80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x5A24CF0", Offset = "0x5A238F0", VA = "0x185A24CF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x5A24930", Offset = "0x5A23530", VA = "0x185A24930")]
		protected BaseRuntimePanel(ScriptableObject ownerObject, [Optional] EventDispatcher dispatcher)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x5A23F60", Offset = "0x5A22B60", VA = "0x185A23F60", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700007C")]
		internal override Shader standardWorldSpaceShader
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x5A24CD0", Offset = "0x5A238D0", VA = "0x185A24CD0", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00002AF0 File Offset: 0x00000CF0
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		internal bool drawToCameras
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x5A24B20", Offset = "0x5A23720", VA = "0x185A24B20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x5A24D90", Offset = "0x5A23990", VA = "0x185A24D90")]
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002B08 File Offset: 0x00000D08
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		internal int targetDisplay
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x5A24CE0", Offset = "0x5A238E0", VA = "0x185A24CE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x5A25050", Offset = "0x5A23C50", VA = "0x185A25050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x1700007F")]
		internal int screenRenderingWidth
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x5A24C00", Offset = "0x5A23800", VA = "0x185A24C00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x17000080")]
		internal int screenRenderingHeight
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x5A24B30", Offset = "0x5A23730", VA = "0x185A24B30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x5A24140", Offset = "0x5A22D40", VA = "0x185A24140", Slot = "22")]
		public override void Repaint(Event e)
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000081")]
		public Func<Vector2, Vector2> screenToPanelSpace
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x5A24E70", Offset = "0x5A23A70", VA = "0x185A24E70")]
			set
			{
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x5A24580", Offset = "0x5A23180", VA = "0x185A24580")]
		internal Vector2 ScreenToPanel(Vector2 screen)
		{
			return default(Vector2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x5A245D0", Offset = "0x5A231D0", VA = "0x185A245D0")]
		internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false)
		{
			return default(bool);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x5A23C50", Offset = "0x5A22850", VA = "0x185A23C50")]
		private void AssignPanelToComponents(BaseRuntimePanel panel)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x5A24060", Offset = "0x5A22C60", VA = "0x185A24060")]
		internal void PointerLeavesPanel(int pointerId, Vector2 position)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x5A23FB0", Offset = "0x5A22BB0", VA = "0x185A23FB0")]
		internal void PointerEntersPanel(int pointerId, Vector2 position)
		{
		}

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private GameObject m_SelectableGameObject;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_CurrentRuntimePanelCounter;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		internal readonly int m_RuntimePanelCreationIndex;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float m_SortingPriority;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Shader m_StandardWorldSpaceShader;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool m_DrawToCameras;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		internal RenderTexture targetTexture;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		internal Matrix4x4 panelToWorld;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Func<Vector2, Vector2> m_ScreenToPanelSpace;
	}
}
