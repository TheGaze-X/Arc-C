using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F12 RID: 16146
	[Token(Token = "0x2003F12")]
	public abstract class SiracusaCharTaskItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x0601911C RID: 102684 RVA: 0x0009CE88 File Offset: 0x0009B088
		[Token(Token = "0x17003BFB")]
		public float itemHeight
		{
			[Token(Token = "0x601911C")]
			[Address(RVA = "0x11B1F40", Offset = "0x11B0B40", VA = "0x1811B1F40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0601911D RID: 102685 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601911E RID: 102686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BFC")]
		public Action<string, string> onTaskClick
		{
			[Token(Token = "0x601911D")]
			[Address(RVA = "0x11B1FD0", Offset = "0x11B0BD0", VA = "0x1811B1FD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601911E")]
			[Address(RVA = "0x11B2030", Offset = "0x11B0C30", VA = "0x1811B2030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601911F RID: 102687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601911F")]
		[Address(RVA = "0x11B1C40", Offset = "0x11B0840", VA = "0x1811B1C40", Slot = "4")]
		public virtual void Render(SiracusaCharTaskRingModel taskRingModel, SiracusaCharTaskModel taskModel)
		{
		}

		// Token: 0x06019120 RID: 102688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019120")]
		[Address(RVA = "0x11B1AF0", Offset = "0x11B06F0", VA = "0x1811B1AF0")]
		public void EventOnTaskClick()
		{
		}

		// Token: 0x06019121 RID: 102689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019121")]
		[Address(RVA = "0x11B1EE0", Offset = "0x11B0AE0", VA = "0x1811B1EE0")]
		protected SiracusaCharTaskItemView()
		{
		}

		// Token: 0x0401F02C RID: 127020
		[Token(Token = "0x401F02C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayoutElement _itemLayout;

		// Token: 0x0401F02D RID: 127021
		[Token(Token = "0x401F02D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textPlaceName;

		// Token: 0x0401F02E RID: 127022
		[Token(Token = "0x401F02E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _completeMaskGo;

		// Token: 0x0401F02F RID: 127023
		[Token(Token = "0x401F02F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _btnNav;

		// Token: 0x0401F030 RID: 127024
		[Token(Token = "0x401F030")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _iconNavGo;

		// Token: 0x0401F031 RID: 127025
		[Token(Token = "0x401F031")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _iconCompletedGo;

		// Token: 0x0401F032 RID: 127026
		[Token(Token = "0x401F032")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _iconInvalidGo;

		// Token: 0x0401F033 RID: 127027
		[Token(Token = "0x401F033")]
		[FieldOffset(Offset = "0x50")]
		private SiracusaCharTaskRingModel m_taskRingModel;

		// Token: 0x0401F034 RID: 127028
		[Token(Token = "0x401F034")]
		[FieldOffset(Offset = "0x58")]
		private SiracusaCharTaskModel m_taskModel;

		// Token: 0x0401F036 RID: 127030
		[Token(Token = "0x401F036")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemHeight;

		// Token: 0x0401F037 RID: 127031
		[Token(Token = "0x401F037")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onTaskClick;

		// Token: 0x0401F038 RID: 127032
		[Token(Token = "0x401F038")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onTaskClick;

		// Token: 0x0401F039 RID: 127033
		[Token(Token = "0x401F039")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F03A RID: 127034
		[Token(Token = "0x401F03A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnTaskClick;

		// Token: 0x0401F03B RID: 127035
		[Token(Token = "0x401F03B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
