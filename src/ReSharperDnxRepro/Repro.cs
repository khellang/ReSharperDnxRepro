namespace ReSharperDnxRepro
{
    public static class Repro
    {
        public static void InHereIWouldLikeToUseTheSharedMethod()
        {
            Shared.ThisIsAMethodIWouldLikeToShareAcrossMultipleProjects();
        }
    }
}
