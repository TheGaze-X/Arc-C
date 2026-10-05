using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C7E RID: 19582
	[Token(Token = "0x2004C7E")]
	public class OpenServerTotalCheckInView : MonoBehaviour
	{
		// Token: 0x0601D5D3 RID: 120275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5D3")]
		[Address(RVA = "0x16ED0B0", Offset = "0x16EBCB0", VA = "0x1816ED0B0")]
		public void Initialize()
		{
		}

		// Token: 0x0601D5D4 RID: 120276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5D4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public OpenServerTotalCheckInView()
		{
		}

		// Token: 0x04026A4F RID: 158287
		[Token(Token = "0x4026A4F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04026A50 RID: 158288
		[Token(Token = "0x4026A50")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRectSoftMask _softMask;

		// Token: 0x04026A51 RID: 158289
		[Token(Token = "0x4026A51")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04026A52 RID: 158290
		[Token(Token = "0x4026A52")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<int> OnGetCheckIn;

		// Token: 0x04026A53 RID: 158291
		[Token(Token = "0x4026A53")]
		[FieldOffset(Offset = "0x38")]
		private OpenServerTotalCheckInView.Adapter m_adapter;

		// Token: 0x04026A54 RID: 158292
		[Token(Token = "0x4026A54")]
		[FieldOffset(Offset = "0x40")]
		private IList<TotalCheckinData> m_viewDataSource;

		// Token: 0x02004C7F RID: 19583
		[Token(Token = "0x2004C7F")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170044E9 RID: 17641
			// (get) Token: 0x0601D5D5 RID: 120277 RVA: 0x000AB408 File Offset: 0x000A9608
			[Token(Token = "0x170044E9")]
			public override int count
			{
				[Token(Token = "0x601D5D5")]
				[Address(RVA = "0x16DD810", Offset = "0x16DC410", VA = "0x1816DD810", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D5D6 RID: 120278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D5D6")]
			[Address(RVA = "0x16DD690", Offset = "0x16DC290", VA = "0x1816DD690")]
			public Adapter(OpenServerTotalCheckInView owner)
			{
			}

			// Token: 0x0601D5D7 RID: 120279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D5D7")]
			[Address(RVA = "0x16DD150", Offset = "0x16DBD50", VA = "0x1816DD150", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026A55 RID: 158293
			[Token(Token = "0x4026A55")]
			[FieldOffset(Offset = "0x20")]
			private OpenServerTotalCheckInView m_owner;

			// Token: 0x04026A56 RID: 158294
			[Token(Token = "0x4026A56")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026A57 RID: 158295
			[Token(Token = "0x4026A57")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026A58 RID: 158296
			[Token(Token = "0x4026A58")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
