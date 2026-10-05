using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200562D RID: 22061
	[Token(Token = "0x200562D")]
	public abstract class RL05SpecialZoneNodeViewBase : MonoBehaviour, IRoguelikeDungeonNodeView, IHotfixable
	{
		// Token: 0x17004BCA RID: 19402
		// (get) Token: 0x0602060B RID: 132619 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602060C RID: 132620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BCA")]
		public Action<RoguelikeDungeonNode> onNodeClick
		{
			[Token(Token = "0x602060B")]
			[Address(RVA = "0x1A86370", Offset = "0x1A84F70", VA = "0x181A86370")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x602060C")]
			[Address(RVA = "0x1A863D0", Offset = "0x1A84FD0", VA = "0x181A863D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602060D RID: 132621
		[Token(Token = "0x602060D")]
		public abstract void Render(RoguelikeDungeonNode node);

		// Token: 0x0602060E RID: 132622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602060E")]
		[Address(RVA = "0x1A86170", Offset = "0x1A84D70", VA = "0x181A86170")]
		public RectTransform GetConnector(RL05SpecialZoneNodeConnector connector)
		{
			return null;
		}

		// Token: 0x0602060F RID: 132623 RVA: 0x000B5A58 File Offset: 0x000B3C58
		[Token(Token = "0x602060F")]
		[Address(RVA = "0x1A86290", Offset = "0x1A84E90", VA = "0x181A86290", Slot = "7")]
		public virtual Color GetSelectableColor()
		{
			return default(Color);
		}

		// Token: 0x06020610 RID: 132624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020610")]
		[Address(RVA = "0x1A86230", Offset = "0x1A84E30", VA = "0x181A86230", Slot = "5")]
		public RectTransform GetRectTransform()
		{
			return null;
		}

		// Token: 0x06020611 RID: 132625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020611")]
		[Address(RVA = "0x1A86310", Offset = "0x1A84F10", VA = "0x181A86310")]
		protected RL05SpecialZoneNodeViewBase()
		{
		}

		// Token: 0x0402BD4C RID: 179532
		[Token(Token = "0x402BD4C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Connectors")]
		private RectTransform _left;

		// Token: 0x0402BD4D RID: 179533
		[Token(Token = "0x402BD4D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Connectors")]
		private RectTransform _right;

		// Token: 0x0402BD4E RID: 179534
		[Token(Token = "0x402BD4E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Connectors")]
		private RectTransform _up;

		// Token: 0x0402BD4F RID: 179535
		[Token(Token = "0x402BD4F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Connectors")]
		private RectTransform _down;

		// Token: 0x0402BD51 RID: 179537
		[Token(Token = "0x402BD51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNodeClick;

		// Token: 0x0402BD52 RID: 179538
		[Token(Token = "0x402BD52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNodeClick;

		// Token: 0x0402BD53 RID: 179539
		[Token(Token = "0x402BD53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetConnector;

		// Token: 0x0402BD54 RID: 179540
		[Token(Token = "0x402BD54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectableColor;

		// Token: 0x0402BD55 RID: 179541
		[Token(Token = "0x402BD55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRectTransform;

		// Token: 0x0402BD56 RID: 179542
		[Token(Token = "0x402BD56")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
