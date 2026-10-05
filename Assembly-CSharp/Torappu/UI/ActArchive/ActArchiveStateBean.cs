using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ADA RID: 27354
	[Token(Token = "0x2006ADA")]
	public class ActArchiveStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17005C7C RID: 23676
		// (get) Token: 0x06027203 RID: 160259 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027204 RID: 160260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C7C")]
		public ActArchiveInfo archiveInfo
		{
			[Token(Token = "0x6027203")]
			[Address(RVA = "0x224E200", Offset = "0x224CE00", VA = "0x18224E200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027204")]
			[Address(RVA = "0x224E260", Offset = "0x224CE60", VA = "0x18224E260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06027205 RID: 160261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027205")]
		[Address(RVA = "0x224DB30", Offset = "0x224C730", VA = "0x18224DB30")]
		public void LoadData(ActArchiveInfo.Param param)
		{
		}

		// Token: 0x06027206 RID: 160262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027206")]
		[Address(RVA = "0x224DCC0", Offset = "0x224C8C0", VA = "0x18224DCC0")]
		public void RefreshEntryComp()
		{
		}

		// Token: 0x06027207 RID: 160263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027207")]
		[Address(RVA = "0x224DFB0", Offset = "0x224CBB0", VA = "0x18224DFB0")]
		public void SetEntryCompType(ActArchiveType compType, DataBundle data)
		{
		}

		// Token: 0x06027208 RID: 160264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027208")]
		[Address(RVA = "0x224DE30", Offset = "0x224CA30", VA = "0x18224DE30")]
		public void SetDetailCompType(ActArchiveType compType, DataBundle data)
		{
		}

		// Token: 0x06027209 RID: 160265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027209")]
		[Address(RVA = "0x224E130", Offset = "0x224CD30", VA = "0x18224E130")]
		public ActArchiveStateBean()
		{
		}

		// Token: 0x04037576 RID: 226678
		[Token(Token = "0x4037576")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public IntProperty selectedEntryCompProp;

		// Token: 0x04037577 RID: 226679
		[Token(Token = "0x4037577")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public IntProperty selectedDetailCompProp;

		// Token: 0x04037578 RID: 226680
		[Token(Token = "0x4037578")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_archiveInfo;

		// Token: 0x04037579 RID: 226681
		[Token(Token = "0x4037579")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_archiveInfo;

		// Token: 0x0403757A RID: 226682
		[Token(Token = "0x403757A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403757B RID: 226683
		[Token(Token = "0x403757B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshEntryComp;

		// Token: 0x0403757C RID: 226684
		[Token(Token = "0x403757C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetEntryCompType;

		// Token: 0x0403757D RID: 226685
		[Token(Token = "0x403757D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetDetailCompType;

		// Token: 0x0403757E RID: 226686
		[Token(Token = "0x403757E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
