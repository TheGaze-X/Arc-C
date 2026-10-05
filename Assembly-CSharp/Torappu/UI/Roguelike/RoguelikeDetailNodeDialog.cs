using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005252 RID: 21074
	[Token(Token = "0x2005252")]
	public class RoguelikeDetailNodeDialog : UICustomDialog<RoguelikeDetailNodeDialog.OptionBase>
	{
		// Token: 0x0601F15B RID: 127323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F15B")]
		[Address(RVA = "0x18C8E90", Offset = "0x18C7A90", VA = "0x1818C8E90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F15C RID: 127324 RVA: 0x000B0DD8 File Offset: 0x000AEFD8
		[Token(Token = "0x601F15C")]
		[Address(RVA = "0x18C90A0", Offset = "0x18C7CA0", VA = "0x1818C90A0")]
		private bool _PrepareSelf(GameObject target)
		{
			return default(bool);
		}

		// Token: 0x0601F15D RID: 127325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F15D")]
		[Address(RVA = "0x18C8BD0", Offset = "0x18C77D0", VA = "0x1818C8BD0", Slot = "7")]
		protected override void OnRender(RoguelikeDetailNodeDialog.OptionBase option)
		{
		}

		// Token: 0x0601F15E RID: 127326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F15E")]
		[Address(RVA = "0x18C8FD0", Offset = "0x18C7BD0", VA = "0x1818C8FD0")]
		private IEnumerator _OnChangeBound(RoguelikeDetailNodeDialog.OptionBase option)
		{
			return null;
		}

		// Token: 0x0601F15F RID: 127327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F15F")]
		[Address(RVA = "0x18C8B60", Offset = "0x18C7760", VA = "0x1818C8B60")]
		public void ClosePanel()
		{
		}

		// Token: 0x0601F160 RID: 127328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F160")]
		[Address(RVA = "0x18C9300", Offset = "0x18C7F00", VA = "0x1818C9300")]
		public RoguelikeDetailNodeDialog()
		{
		}

		// Token: 0x04029B2C RID: 170796
		[Token(Token = "0x4029B2C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _panel;

		// Token: 0x04029B2D RID: 170797
		[Token(Token = "0x4029B2D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _padding;

		// Token: 0x04029B2E RID: 170798
		[Token(Token = "0x4029B2E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeDetailNodeDialog.ViewBase _view;

		// Token: 0x04029B2F RID: 170799
		[Token(Token = "0x4029B2F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04029B30 RID: 170800
		[Token(Token = "0x4029B30")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04029B31 RID: 170801
		[Token(Token = "0x4029B31")]
		[FieldOffset(Offset = "0x70")]
		private Camera m_targetCamera;

		// Token: 0x04029B32 RID: 170802
		[Token(Token = "0x4029B32")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_target;

		// Token: 0x04029B33 RID: 170803
		[Token(Token = "0x4029B33")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform m_transTarget;

		// Token: 0x04029B34 RID: 170804
		[Token(Token = "0x4029B34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029B35 RID: 170805
		[Token(Token = "0x4029B35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PrepareSelf;

		// Token: 0x04029B36 RID: 170806
		[Token(Token = "0x4029B36")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04029B37 RID: 170807
		[Token(Token = "0x4029B37")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnChangeBound;

		// Token: 0x04029B38 RID: 170808
		[Token(Token = "0x4029B38")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClosePanel;

		// Token: 0x04029B39 RID: 170809
		[Token(Token = "0x4029B39")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005253 RID: 21075
		[Token(Token = "0x2005253")]
		public class OptionBase
		{
			// Token: 0x0601F161 RID: 127329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F161")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OptionBase()
			{
			}

			// Token: 0x04029B3A RID: 170810
			[Token(Token = "0x4029B3A")]
			[FieldOffset(Offset = "0x10")]
			public GameObject target;
		}

		// Token: 0x02005254 RID: 21076
		[Token(Token = "0x2005254")]
		public abstract class ViewBase : MonoBehaviour, IHotfixable
		{
			// Token: 0x0601F162 RID: 127330
			[Token(Token = "0x601F162")]
			public abstract void OnInit();

			// Token: 0x0601F163 RID: 127331
			[Token(Token = "0x601F163")]
			public abstract void OnRender(RoguelikeDetailNodeDialog.OptionBase options);

			// Token: 0x0601F164 RID: 127332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F164")]
			[Address(RVA = "0x18DD3A0", Offset = "0x18DBFA0", VA = "0x1818DD3A0")]
			protected ViewBase()
			{
			}

			// Token: 0x04029B3B RID: 170811
			[Token(Token = "0x4029B3B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005255 RID: 21077
		[Token(Token = "0x2005255")]
		public abstract class View<T> : RoguelikeDetailNodeDialog.ViewBase where T : RoguelikeDetailNodeDialog.OptionBase
		{
			// Token: 0x0601F165 RID: 127333
			[Token(Token = "0x601F165")]
			public abstract void Render(T options);

			// Token: 0x0601F166 RID: 127334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F166")]
			public override void OnRender(RoguelikeDetailNodeDialog.OptionBase optionsBase)
			{
			}

			// Token: 0x0601F167 RID: 127335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F167")]
			protected View()
			{
			}

			// Token: 0x04029B3C RID: 170812
			[Token(Token = "0x4029B3C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnRender;

			// Token: 0x04029B3D RID: 170813
			[Token(Token = "0x4029B3D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
