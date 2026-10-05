using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F7E RID: 16254
	[Token(Token = "0x2003F7E")]
	public class SiracusaBigMapTaskArrow : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019378 RID: 103288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019378")]
		[Address(RVA = "0x11E5C80", Offset = "0x11E4880", VA = "0x1811E5C80")]
		private FadeSwitchTween _EnsureSwitchTween()
		{
			return null;
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x06019379 RID: 103289 RVA: 0x0009D458 File Offset: 0x0009B658
		[Token(Token = "0x17003C36")]
		public Vector2 boundSize
		{
			[Token(Token = "0x6019379")]
			[Address(RVA = "0x11E5E00", Offset = "0x11E4A00", VA = "0x1811E5E00")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0601937A RID: 103290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601937A")]
		[Address(RVA = "0x11E59E0", Offset = "0x11E45E0", VA = "0x1811E59E0")]
		public void Init()
		{
		}

		// Token: 0x0601937B RID: 103291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601937B")]
		[Address(RVA = "0x11E5960", Offset = "0x11E4560", VA = "0x1811E5960")]
		public void Disable()
		{
		}

		// Token: 0x0601937C RID: 103292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601937C")]
		[Address(RVA = "0x11E5A60", Offset = "0x11E4660", VA = "0x1811E5A60")]
		public void Render(Vector2 direction, Color themeColor)
		{
		}

		// Token: 0x0601937D RID: 103293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601937D")]
		[Address(RVA = "0x11E5D50", Offset = "0x11E4950", VA = "0x1811E5D50")]
		public SiracusaBigMapTaskArrow()
		{
		}

		// Token: 0x0401F463 RID: 128099
		[Token(Token = "0x401F463")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0401F464 RID: 128100
		[Token(Token = "0x401F464")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _transArrow;

		// Token: 0x0401F465 RID: 128101
		[Token(Token = "0x401F465")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _themeGraphic;

		// Token: 0x0401F466 RID: 128102
		[Token(Token = "0x401F466")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _boundSize;

		// Token: 0x0401F467 RID: 128103
		[Token(Token = "0x401F467")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 m_cachedDirection;

		// Token: 0x0401F468 RID: 128104
		[Token(Token = "0x401F468")]
		[FieldOffset(Offset = "0x40")]
		private Color m_cachedColor;

		// Token: 0x0401F469 RID: 128105
		[Token(Token = "0x401F469")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0401F46A RID: 128106
		[Token(Token = "0x401F46A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureSwitchTween;

		// Token: 0x0401F46B RID: 128107
		[Token(Token = "0x401F46B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_boundSize;

		// Token: 0x0401F46C RID: 128108
		[Token(Token = "0x401F46C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F46D RID: 128109
		[Token(Token = "0x401F46D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Disable;

		// Token: 0x0401F46E RID: 128110
		[Token(Token = "0x401F46E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F46F RID: 128111
		[Token(Token = "0x401F46F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
