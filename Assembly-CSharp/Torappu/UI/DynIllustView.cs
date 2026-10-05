using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020034E3 RID: 13539
	[Token(Token = "0x20034E3")]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(RawImage))]
	public class DynIllustView : MonoBehaviour
	{
		// Token: 0x0601592C RID: 88364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601592C")]
		[Address(RVA = "0xE04250", Offset = "0xE02E50", VA = "0x180E04250")]
		private void Awake()
		{
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0601592D RID: 88365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601592E RID: 88366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003301")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x601592D")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601592E")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0601592F RID: 88367 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015930 RID: 88368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003302")]
		public RawImage rawImage
		{
			[Token(Token = "0x601592F")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015930")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x06015931 RID: 88369 RVA: 0x0008CA90 File Offset: 0x0008AC90
		[Token(Token = "0x17003303")]
		public bool isSpecialDynIllust
		{
			[Token(Token = "0x6015931")]
			[Address(RVA = "0xE046C0", Offset = "0xE032C0", VA = "0x180E046C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x06015932 RID: 88370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003304")]
		public DynIllustBase res
		{
			[Token(Token = "0x6015932")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x06015933 RID: 88371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003305")]
		public DynIllustBase inst
		{
			[Token(Token = "0x6015933")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x06015934 RID: 88372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003306")]
		public DynIllustMgr.Context context
		{
			[Token(Token = "0x6015934")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015935 RID: 88373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015935")]
		[Address(RVA = "0xE045D0", Offset = "0xE031D0", VA = "0x180E045D0")]
		public void Init(DynIllustBase illustRes, DynIllustMgr.Context context)
		{
		}

		// Token: 0x06015936 RID: 88374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015936")]
		[Address(RVA = "0xE04430", Offset = "0xE03030", VA = "0x180E04430")]
		public Camera GetUICamera()
		{
			return null;
		}

		// Token: 0x06015937 RID: 88375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015937")]
		[Address(RVA = "0xE04360", Offset = "0xE02F60", VA = "0x180E04360")]
		public Canvas GetRootCanvas()
		{
			return null;
		}

		// Token: 0x06015938 RID: 88376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015938")]
		[Address(RVA = "0xE04030", Offset = "0xE02C30", VA = "0x180E04030")]
		public void Active()
		{
		}

		// Token: 0x06015939 RID: 88377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015939")]
		[Address(RVA = "0xE042C0", Offset = "0xE02EC0", VA = "0x180E042C0")]
		public void ClearAdjust()
		{
		}

		// Token: 0x0601593A RID: 88378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601593A")]
		[Address(RVA = "0xE04090", Offset = "0xE02C90", VA = "0x180E04090")]
		public void ApplyAdjust(DynIllustAdjustType type)
		{
		}

		// Token: 0x0601593B RID: 88379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601593B")]
		[Address(RVA = "0xE04550", Offset = "0xE03150", VA = "0x180E04550")]
		public void InitComponent()
		{
		}

		// Token: 0x0601593C RID: 88380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601593C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DynIllustView()
		{
		}

		// Token: 0x04019DF1 RID: 105969
		[Token(Token = "0x4019DF1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DynIllustBase _illust;

		// Token: 0x04019DF2 RID: 105970
		[Token(Token = "0x4019DF2")]
		[FieldOffset(Offset = "0x20")]
		private DynIllustBase m_inst;

		// Token: 0x04019DF3 RID: 105971
		[Token(Token = "0x4019DF3")]
		[FieldOffset(Offset = "0x28")]
		private DynIllustMgr.Context m_context;
	}
}
