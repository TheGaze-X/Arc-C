using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F81 RID: 16257
	[Token(Token = "0x2003F81")]
	public abstract class SiracusaMapAreaFogViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0601938B RID: 103307 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601938C RID: 103308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C37")]
		public AutoPackSpriteHub areaIconSpriteHub
		{
			[Token(Token = "0x601938B")]
			[Address(RVA = "0x11E6890", Offset = "0x11E5490", VA = "0x1811E6890")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601938C")]
			[Address(RVA = "0x11E6A20", Offset = "0x11E5620", VA = "0x1811E6A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x0601938D RID: 103309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C38")]
		public string areaId
		{
			[Token(Token = "0x601938D")]
			[Address(RVA = "0x11E68F0", Offset = "0x11E54F0", VA = "0x1811E68F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x0601938E RID: 103310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C39")]
		protected UISwitchTween fadeTween
		{
			[Token(Token = "0x601938E")]
			[Address(RVA = "0x11E6950", Offset = "0x11E5550", VA = "0x1811E6950")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601938F RID: 103311
		[Token(Token = "0x601938F")]
		public abstract void Render(SiracusaData.AreaData areaData, bool isShow);

		// Token: 0x06019390 RID: 103312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019390")]
		[Address(RVA = "0x11E6830", Offset = "0x11E5430", VA = "0x1811E6830")]
		protected SiracusaMapAreaFogViewBase()
		{
		}

		// Token: 0x0401F487 RID: 128135
		[Token(Token = "0x401F487")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401F488 RID: 128136
		[Token(Token = "0x401F488")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _areaId;

		// Token: 0x0401F489 RID: 128137
		[Token(Token = "0x401F489")]
		[FieldOffset(Offset = "0x28")]
		private UISwitchTween m_fadeTween;

		// Token: 0x0401F48B RID: 128139
		[Token(Token = "0x401F48B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_areaIconSpriteHub;

		// Token: 0x0401F48C RID: 128140
		[Token(Token = "0x401F48C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_areaIconSpriteHub;

		// Token: 0x0401F48D RID: 128141
		[Token(Token = "0x401F48D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_areaId;

		// Token: 0x0401F48E RID: 128142
		[Token(Token = "0x401F48E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_fadeTween;

		// Token: 0x0401F48F RID: 128143
		[Token(Token = "0x401F48F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
