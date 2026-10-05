using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E13 RID: 28179
	[Token(Token = "0x2006E13")]
	public class ActVecBreakV2DefenseCharListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005ED8 RID: 24280
		// (get) Token: 0x060281C9 RID: 164297 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060281CA RID: 164298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005ED8")]
		public Action<string> onRemoveSquadClick
		{
			[Token(Token = "0x60281C9")]
			[Address(RVA = "0x2361880", Offset = "0x2360480", VA = "0x182361880")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60281CA")]
			[Address(RVA = "0x23618E0", Offset = "0x23604E0", VA = "0x1823618E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060281CB RID: 164299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281CB")]
		[Address(RVA = "0x23614A0", Offset = "0x23600A0", VA = "0x1823614A0")]
		public void Render(List<ActVecBreakV2DefenseCharSlotModel> charList, string stageId)
		{
		}

		// Token: 0x060281CC RID: 164300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281CC")]
		[Address(RVA = "0x2361700", Offset = "0x2360300", VA = "0x182361700")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060281CD RID: 164301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281CD")]
		[Address(RVA = "0x2361390", Offset = "0x235FF90", VA = "0x182361390")]
		public void EventRemoveDefenseSquad()
		{
		}

		// Token: 0x060281CE RID: 164302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281CE")]
		[Address(RVA = "0x2361820", Offset = "0x2360420", VA = "0x182361820")]
		public ActVecBreakV2DefenseCharListView()
		{
		}

		// Token: 0x04038ED7 RID: 233175
		[Token(Token = "0x4038ED7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _slotContent;

		// Token: 0x04038ED8 RID: 233176
		[Token(Token = "0x4038ED8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _removeSquadToggle;

		// Token: 0x04038EDA RID: 233178
		[Token(Token = "0x4038EDA")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04038EDB RID: 233179
		[Token(Token = "0x4038EDB")]
		[FieldOffset(Offset = "0x38")]
		private List<ActVecBreakV2DefenseCharSlotModel> m_cachedList;

		// Token: 0x04038EDC RID: 233180
		[Token(Token = "0x4038EDC")]
		[FieldOffset(Offset = "0x40")]
		private ActVecBreakV2DefenseCharListView.Adapter m_adapter;

		// Token: 0x04038EDD RID: 233181
		[Token(Token = "0x4038EDD")]
		[FieldOffset(Offset = "0x48")]
		private string m_cacheStageId;

		// Token: 0x04038EDE RID: 233182
		[Token(Token = "0x4038EDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRemoveSquadClick;

		// Token: 0x04038EDF RID: 233183
		[Token(Token = "0x4038EDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRemoveSquadClick;

		// Token: 0x04038EE0 RID: 233184
		[Token(Token = "0x4038EE0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038EE1 RID: 233185
		[Token(Token = "0x4038EE1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038EE2 RID: 233186
		[Token(Token = "0x4038EE2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventRemoveDefenseSquad;

		// Token: 0x04038EE3 RID: 233187
		[Token(Token = "0x4038EE3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E14 RID: 28180
		[Token(Token = "0x2006E14")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060281CF RID: 164303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60281CF")]
			[Address(RVA = "0x2372800", Offset = "0x2371400", VA = "0x182372800")]
			public Adapter(ActVecBreakV2DefenseCharListView closure)
			{
			}

			// Token: 0x17005ED9 RID: 24281
			// (get) Token: 0x060281D0 RID: 164304 RVA: 0x000D0B18 File Offset: 0x000CED18
			[Token(Token = "0x17005ED9")]
			public override int count
			{
				[Token(Token = "0x60281D0")]
				[Address(RVA = "0x2372A80", Offset = "0x2371680", VA = "0x182372A80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060281D1 RID: 164305 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60281D1")]
			[Address(RVA = "0x23721D0", Offset = "0x2370DD0", VA = "0x1823721D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038EE4 RID: 233188
			[Token(Token = "0x4038EE4")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2DefenseCharListView m_closure;

			// Token: 0x04038EE5 RID: 233189
			[Token(Token = "0x4038EE5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038EE6 RID: 233190
			[Token(Token = "0x4038EE6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038EE7 RID: 233191
			[Token(Token = "0x4038EE7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
