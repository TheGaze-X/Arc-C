using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AsyncLoader
{
	// Token: 0x020016D3 RID: 5843
	[Token(Token = "0x20016D3")]
	public class AsyncGameObjectLoader : AsyncLoaderBase
	{
		// Token: 0x06009401 RID: 37889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009401")]
		[Address(RVA = "0x2B25340", Offset = "0x2B23F40", VA = "0x182B25340")]
		public void StartTask(int index, AsyncGameObjectLoader.Handler handler)
		{
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009402")]
		[Address(RVA = "0x2B253E0", Offset = "0x2B23FE0", VA = "0x182B253E0")]
		public void StartTask(int group, int index, AsyncGameObjectLoader.Handler handler)
		{
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009403")]
		[Address(RVA = "0x2B250B0", Offset = "0x2B23CB0", VA = "0x182B250B0")]
		public void ModifyLoadingOrders(IEnumerator<AsyncGameObjectLoader.ModifyOrder> iter)
		{
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009404")]
		[Address(RVA = "0x2B25480", Offset = "0x2B24080", VA = "0x182B25480")]
		private void _StartTaskImpl(AsyncOrder order, AsyncGameObjectLoader.Handler handler)
		{
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009405")]
		[Address(RVA = "0x2B252E0", Offset = "0x2B23EE0", VA = "0x182B252E0", Slot = "5")]
		protected override void OnTaskLoaded(AsyncTaskBase task)
		{
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009406")]
		[Address(RVA = "0x2B25820", Offset = "0x2B24420", VA = "0x182B25820")]
		public AsyncGameObjectLoader()
		{
		}

		// Token: 0x040089DC RID: 35292
		[Token(Token = "0x40089DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_StartTask;

		// Token: 0x040089DD RID: 35293
		[Token(Token = "0x40089DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_StartTask;

		// Token: 0x040089DE RID: 35294
		[Token(Token = "0x40089DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ModifyLoadingOrders;

		// Token: 0x040089DF RID: 35295
		[Token(Token = "0x40089DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__StartTaskImpl;

		// Token: 0x040089E0 RID: 35296
		[Token(Token = "0x40089E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTaskLoaded;

		// Token: 0x040089E1 RID: 35297
		[Token(Token = "0x40089E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020016D4 RID: 5844
		[Token(Token = "0x20016D4")]
		public struct ModifyOrder
		{
			// Token: 0x040089E2 RID: 35298
			[Token(Token = "0x40089E2")]
			[FieldOffset(Offset = "0x0")]
			public AsyncOrder order;

			// Token: 0x040089E3 RID: 35299
			[Token(Token = "0x40089E3")]
			[FieldOffset(Offset = "0x8")]
			public AsyncGameObjectLoader.Handler handler;
		}

		// Token: 0x020016D5 RID: 5845
		[Token(Token = "0x20016D5")]
		public abstract class Handler : IHotfixable
		{
			// Token: 0x06009407 RID: 37895 RVA: 0x00039C48 File Offset: 0x00037E48
			[Token(Token = "0x6009407")]
			[Address(RVA = "0x2B3A0A0", Offset = "0x2B38CA0", VA = "0x182B3A0A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06009408 RID: 37896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009408")]
			[Address(RVA = "0x2B3A330", Offset = "0x2B38F30", VA = "0x182B3A330")]
			public void SetActive(bool isActive)
			{
			}

			// Token: 0x06009409 RID: 37897 RVA: 0x00039C60 File Offset: 0x00037E60
			[Token(Token = "0x6009409")]
			[Address(RVA = "0x2B39DF0", Offset = "0x2B389F0", VA = "0x182B39DF0")]
			public bool Destroy()
			{
				return default(bool);
			}

			// Token: 0x0600940A RID: 37898
			[Token(Token = "0x600940A")]
			protected abstract void OnGameObjectLoaded(GameObject obj);

			// Token: 0x0600940B RID: 37899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600940B")]
			[Address(RVA = "0x2B3A3F0", Offset = "0x2B38FF0", VA = "0x182B3A3F0")]
			public void TaskOnlySetGameObject(GameObject obj)
			{
			}

			// Token: 0x17000FDE RID: 4062
			// (get) Token: 0x0600940C RID: 37900 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600940D RID: 37901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000FDE")]
			public AsyncTaskBase loaderOnlyTask
			{
				[Token(Token = "0x600940C")]
				[Address(RVA = "0x2B3A510", Offset = "0x2B39110", VA = "0x182B3A510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600940D")]
				[Address(RVA = "0x2B3A570", Offset = "0x2B39170", VA = "0x182B3A570")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600940E RID: 37902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600940E")]
			[Address(RVA = "0x2B3A160", Offset = "0x2B38D60", VA = "0x182B3A160")]
			public AsyncTaskBase LoaderOnlyCreateTask()
			{
				return null;
			}

			// Token: 0x0600940F RID: 37903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600940F")]
			[Address(RVA = "0x2B3A4A0", Offset = "0x2B390A0", VA = "0x182B3A4A0")]
			protected Handler()
			{
			}

			// Token: 0x040089E4 RID: 35300
			[Token(Token = "0x40089E4")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isActive;

			// Token: 0x040089E5 RID: 35301
			[Token(Token = "0x40089E5")]
			[FieldOffset(Offset = "0x18")]
			private GameObject m_gameObj;

			// Token: 0x040089E6 RID: 35302
			[Token(Token = "0x40089E6")]
			[FieldOffset(Offset = "0x20")]
			public uint costPerObj;

			// Token: 0x040089E7 RID: 35303
			[Token(Token = "0x40089E7")]
			[FieldOffset(Offset = "0x28")]
			public GameObject prefab;

			// Token: 0x040089E8 RID: 35304
			[Token(Token = "0x40089E8")]
			[FieldOffset(Offset = "0x30")]
			public Transform container;

			// Token: 0x040089E9 RID: 35305
			[Token(Token = "0x40089E9")]
			[FieldOffset(Offset = "0x38")]
			public Component maintainer;

			// Token: 0x040089EB RID: 35307
			[Token(Token = "0x40089EB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x040089EC RID: 35308
			[Token(Token = "0x40089EC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetActive;

			// Token: 0x040089ED RID: 35309
			[Token(Token = "0x40089ED")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Destroy;

			// Token: 0x040089EE RID: 35310
			[Token(Token = "0x40089EE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_TaskOnlySetGameObject;

			// Token: 0x040089EF RID: 35311
			[Token(Token = "0x40089EF")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_loaderOnlyTask;

			// Token: 0x040089F0 RID: 35312
			[Token(Token = "0x40089F0")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_loaderOnlyTask;

			// Token: 0x040089F1 RID: 35313
			[Token(Token = "0x40089F1")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_LoaderOnlyCreateTask;

			// Token: 0x040089F2 RID: 35314
			[Token(Token = "0x40089F2")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020016D6 RID: 5846
		[Token(Token = "0x20016D6")]
		protected class InstantiateTask : AsyncTaskBase
		{
			// Token: 0x06009410 RID: 37904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009410")]
			[Address(RVA = "0x2B3A860", Offset = "0x2B39460", VA = "0x182B3A860")]
			public InstantiateTask(AsyncGameObjectLoader.Handler handler)
			{
			}

			// Token: 0x06009411 RID: 37905 RVA: 0x00039C78 File Offset: 0x00037E78
			[Token(Token = "0x6009411")]
			[Address(RVA = "0x2B3A6C0", Offset = "0x2B392C0", VA = "0x182B3A6C0", Slot = "6")]
			public override bool WorkOnce(out uint cost)
			{
				return default(bool);
			}

			// Token: 0x06009412 RID: 37906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009412")]
			[Address(RVA = "0x2B3A5F0", Offset = "0x2B391F0", VA = "0x182B3A5F0", Slot = "7")]
			protected override void OnDisposed()
			{
			}

			// Token: 0x040089F3 RID: 35315
			[Token(Token = "0x40089F3")]
			[FieldOffset(Offset = "0x20")]
			private GameObject m_inst;

			// Token: 0x040089F4 RID: 35316
			[Token(Token = "0x40089F4")]
			[FieldOffset(Offset = "0x28")]
			private AsyncGameObjectLoader.Handler m_handler;

			// Token: 0x040089F5 RID: 35317
			[Token(Token = "0x40089F5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040089F6 RID: 35318
			[Token(Token = "0x40089F6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_WorkOnce;

			// Token: 0x040089F7 RID: 35319
			[Token(Token = "0x40089F7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnDisposed;
		}
	}
}
