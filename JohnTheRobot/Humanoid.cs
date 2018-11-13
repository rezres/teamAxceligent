namespace JohnTheRobot
{
    public class Humanoid
    {
        protected ISkill Skill { get; set; }

        public Humanoid() { }
        public Humanoid(ISkill skill)
        {
            Skill = skill;
        }
        public string ShowSkill()
        {
            if (Skill != null)
                return this.Skill.GetName();
            else
                return "no skill is defined";
        }
    }

}
