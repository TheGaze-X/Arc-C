using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C7B RID: 19579
	[Token(Token = "0x2004C7B")]
	public class OpenServerMissionView : MonoBehaviour
	{
		// Token: 0x0601D5CA RID: 120266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5CA")]
		[Address(RVA = "0x16EC500", Offset = "0x16EB100", VA = "0x1816EC500")]
		public void Initialize()
		{
		}

		// Token: 0x0601D5CB RID: 120267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5CB")]
		[Address(RVA = "0x16EC8E0", Offset = "0x16EB4E0", VA = "0x1816EC8E0")]
		public OpenServerMissionView()
		{
		}

		// Token: 0x04026A33 RID: 158259
		[Token(Token = "0x4026A33")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04026A34 RID: 158260
		[Token(Token = "0x4026A34")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRectSoftMask _softMask;

		// Token: 0x04026A35 RID: 158261
		[Token(Token = "0x4026A35")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<string> OnGetMissionReward;

		// Token: 0x04026A36 RID: 158262
		[Token(Token = "0x4026A36")]
		[FieldOffset(Offset = "0x30")]
		private OpenServerMissionView.Adapter m_adapter;

		// Token: 0x04026A37 RID: 158263
		[Token(Token = "0x4026A37")]
		[FieldOffset(Offset = "0x38")]
		public List<KeyValuePair<MissionData, MissionPlayerState>> m_viewDataSource;

		// Token: 0x02004C7C RID: 19580
		[Token(Token = "0x2004C7C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170044E8 RID: 17640
			// (get) Token: 0x0601D5CC RID: 120268 RVA: 0x000AB3F0 File Offset: 0x000A95F0
			[Token(Token = "0x170044E8")]
			public override int count
			{
				[Token(Token = "0x601D5CC")]
				[Address(RVA = "0x16DD910", Offset = "0x16DC510", VA = "0x1816DD910", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D5CD RID: 120269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D5CD")]
			[Address(RVA = "0x16DD790", Offset = "0x16DC390", VA = "0x1816DD790")]
			public Adapter(OpenServerMissionView owner)
			{
			}

			// Token: 0x0601D5CE RID: 120270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D5CE")]
			[Address(RVA = "0x16DCDA0", Offset = "0x16DB9A0", VA = "0x1816DCDA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026A38 RID: 158264
			[Token(Token = "0x4026A38")]
			[FieldOffset(Offset = "0x20")]
			private OpenServerMissionView m_owner;

			// Token: 0x04026A39 RID: 158265
			[Token(Token = "0x4026A39")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026A3A RID: 158266
			[Token(Token = "0x4026A3A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026A3B RID: 158267
			[Token(Token = "0x4026A3B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
